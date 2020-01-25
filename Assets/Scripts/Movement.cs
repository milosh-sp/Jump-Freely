using System;
using Unity.Notifications.Android;
using UnityEngine;

public class Movement : MonoBehaviour
{
   
    private float velocity;
    private float step;
    private float yVelocity = 0f;
    private float jumpPercentage;

    public GameObject follow;
    public GameObject menu;

    private int score = -1;
    private float timer = -1f;
    private bool jumpFlag = true;

    void Awake()
    {
        velocity = -10;
        step = 0.42f;
        timer = -1f;
       
    }

    void Start()
    {
        score = PlayerPrefs.GetInt("savedScore");
        PlayerPrefs.SetInt("savedScore", 0);
        PlayerPrefs.SetInt("Score", score);
    }

    public void SetTimer()
    {
        timer = 5f;
    }
    //(Input.GetTouch(0).phase == TouchPhase.Began)

        
    void CreateNotification()
    {
        var notification = new AndroidNotification();
        notification.Title = "Jump Free";
        notification.Text = "That highscore looks kind of low " + PlayerPrefs.GetInt("Highscore") + " let's fix that play now!";
        notification.FireTime = DateTime.Now.AddDays(1);
        notification.RepeatInterval = TimeSpan.FromDays(2);

        var indentifier = AndroidNotificationCenter.SendNotification(notification, "channel_id");
    }
    

        /*
    public void ScheduleiOSNotification()
    {
        UnityEngine.iOS.LocalNotification not = new UnityEngine.iOS.LocalNotification();

        not.fireDate = DateTime.Now.AddDays(1);
        not.alertTitle = "Jump Free";
        not.alertBody = "That highscore looks kind of low " + PlayerPrefs.GetInt("Highscore") + " play now and see if you can beat it.";
        not.repeatInterval = UnityEngine.iOS.CalendarUnit.Day;

        UnityEngine.iOS.NotificationServices.ScheduleLocalNotification(not);
    }
    */


    void Update()
    {

            if ((Input.touchCount > 0 || Input.GetKeyDown(KeyCode.Space)) && jumpFlag && timer < 0 && !menu.GetComponent<MainMenu>().gamePaused)
            {   
                yVelocity = 1f;
                jumpPercentage = -0.3f;
                jumpFlag = false;
                timer = 14f;
            }

            if (Input.GetKeyUp(KeyCode.Escape))
            {
                PlayerPrefs.SetInt("Clicked", 0);
                PlayerPrefs.SetInt("Death", 0);
                PlayerPrefs.SetInt("Tries", 0);
                PlayerPrefs.SetInt("savedScore", 0);
                PlayerPrefs.SetInt("AdPlayed", 0);
                PlayerPrefs.SetInt("Score", 0);
            
             AndroidNotificationCenter.CancelAllScheduledNotifications();
             CreateNotification();
             
           
            /*
            UnityEngine.iOS.NotificationServices.ClearLocalNotifications();
            UnityEngine.iOS.NotificationServices.CancelAllLocalNotifications();
            ScheduleiOSNotification();
            */
             
            Application.Quit();    
            return;
            }

            if(timer>-5)
                timer -= 1f;
            transform.position = new Vector3(velocity, transform.position.y + yVelocity * Time.timeScale, transform.position.z);

        if (Time.timeScale == 1f)
        {
            velocity += step * Time.timeScale;
        }

            if (yVelocity > 0f)
            {
                yVelocity -= jumpPercentage;
                jumpPercentage += 0.12f;
                jumpFlag = false;
            }
            else
            {
                yVelocity = 0f;
                jumpFlag = true;
            }

            if (follow.transform.position.y + 12f < transform.position.y)
            {
                follow.GetComponent<CameraMovement>().velocity += 1f;
            }
    }   

    void OnCollisionEnter2D(Collision2D coll)
    {

        if (coll.gameObject.tag == "LeftWall")
        {

            if (coll.gameObject.GetComponent<WallScript>().flag == false)
            {
                if (step < 0)
                {
                    step *= -1;
                }
            }
        }

        if (coll.gameObject.tag == "RightWall")
        {

            if (coll.gameObject.GetComponent<WallScript>().flag == false)
            {
                if (step > 0)
                {
                    step *= -1;
                }
            }

        }

        if (coll.gameObject.tag == "Floor")
        {

            if (coll.gameObject.GetComponent<FloorScript>().isScoreSet == false)
            {
                score++;
                coll.gameObject.GetComponent<FloorScript>().isScoreSet = true;

                PlayerPrefs.SetInt("Score",score-1);
            }
        }

    }
}
