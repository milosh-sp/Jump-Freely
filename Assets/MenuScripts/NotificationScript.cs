using UnityEngine;
using System;
using Unity.Notifications.Android;

public class NotificationScript : MonoBehaviour
{

    /*
    
      void Awake()
      {    
          UnityEngine.iOS.NotificationServices.RegisterForNotifications(UnityEngine.iOS.NotificationType.Alert | UnityEngine.iOS.NotificationType.Badge | UnityEngine.iOS.NotificationType.Sound);   
      }

      public void ScheduleiOSNotification()
      {
          UnityEngine.iOS.LocalNotification not = new UnityEngine.iOS.LocalNotification();

          not.fireDate = DateTime.Now.AddDays(1);
          not.alertTitle = "Jump Free";
          not.alertBody = "That highscore looks kind of low " + PlayerPrefs.GetInt("Highscore") + " play now and see if you can beat it.";
          not.repeatInterval = UnityEngine.iOS.CalendarUnit.Day;

          UnityEngine.iOS.NotificationServices.ScheduleLocalNotification(not);  
      }

      void OnApplicationPause(bool isPause)
      { 
          UnityEngine.iOS.NotificationServices.ClearLocalNotifications();
          UnityEngine.iOS.NotificationServices.CancelAllLocalNotifications();

          if (isPause)
          {
              UnityEngine.iOS.NotificationServices.ClearLocalNotifications();
              UnityEngine.iOS.NotificationServices.CancelAllLocalNotifications();
              ScheduleiOSNotification();
          }
      }

    */
      

 
    void RegisterChannel()
    {
        var c = new AndroidNotificationChannel()
        {
            Id = "channel_id",
            Name = "Default Channel",
            Importance = Importance.High,
            Description = "Generic notifications",
        };
        AndroidNotificationCenter.RegisterNotificationChannel(c);
    }

    void CreateNotification()
    {
        var notification = new AndroidNotification();
        notification.Title = "Jump Free";
        notification.Text = "That highscore looks kind of low " + PlayerPrefs.GetInt("Highscore") + " let's fix that play now!";
        notification.FireTime = DateTime.Now.AddDays(1);
        notification.RepeatInterval = TimeSpan.FromDays(1);

        var indentifier = AndroidNotificationCenter.SendNotification(notification, "channel_id");        
       
    }

    void Awake()
    {      
        AndroidNotificationCenter.CancelAllScheduledNotifications();
        RegisterChannel();
    }

    void OnApplicationPause(bool isPaused)
    {
       
        AndroidNotificationCenter.CancelAllScheduledNotifications();

        if (isPaused)
        {
            
            AndroidNotificationCenter.CancelAllScheduledNotifications();
            CreateNotification();
        }
    }  

    
}
