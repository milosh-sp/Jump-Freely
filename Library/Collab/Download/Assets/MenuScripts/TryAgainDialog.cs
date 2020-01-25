
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEngine.Monetization;
//using UnityEngine.Advertisements;
using System.Collections;
using UnityEngine.UI;

public class TryAgainDialog : MonoBehaviour
{
    /*
    private string StoreIdAndroid = "3047233";
    private string StoreIdiOS = "3047232";
    */

    public GameObject skinsMenu;
    /*
    private string Video = "video";
    private string Banner = "banner";
    */

    public Text timerText;

    private int tries = 0;
    private bool started = false;
    private int timer = 3;

    public void Restart()
    {
        tries = PlayerPrefs.GetInt("Tries");
        ++tries;
        PlayerPrefs.SetInt("Tries",tries);
        PlayerPrefs.SetInt("Clicked", 1);
        PlayerPrefs.SetInt("Death", 0);
        PlayerPrefs.SetInt("TimesPlayed", PlayerPrefs.GetInt("TimesPlayed") + 1);

        if (PlayerPrefs.GetInt("Tries") % 5 == 0)
        {
            //PlayAd();

            AdScript.instance.ShowInterstetialAd();

        }

        PlayerPrefs.SetInt("AdPlayed", 0);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);     
    }

    void Awake()
    {
        started = false;
        
       // Monetization.Initialize(StoreIdAndroid, false); //kd ke se release game treba da e FALSE
        //Advertisement.Initialize(StoreIdAndroid, false);
        //StartCoroutine(ShowBannerWhenReady());
        StartCoroutine(SkipWithTimer());
    }

    /*
    void PlayAd()
    {
        if (Monetization.IsReady(Video))
        {
            ShowAdPlacementContent Ad = null;
            Ad = Monetization.GetPlacementContent(Video) as ShowAdPlacementContent;

            if (Ad != null)
            {
                Ad.Show();
            }
        }
    }

    void BannerAd()
    {
        if (Monetization.IsReady(Banner))
        {
            ShowAdPlacementContent Ad = null;
            Ad = Monetization.GetPlacementContent(Banner) as ShowAdPlacementContent;

            if (Ad != null)
            {
                started = true;
                Ad.Show();
            }
        }
    }

    */
    private IEnumerator SkipWithTimer()
    {
        while(timer!=0)
        {
            yield return new WaitForSeconds(1);
            if(skinsMenu.activeSelf != true)
                timer--;
            timerText.text = timer.ToString();
        }
        Restart();
    }
    /*
    IEnumerator ShowBannerWhenReady()
    {
        while (!Advertisement.IsReady(Banner))
        {
            yield return new WaitForSeconds(0.5f);
        }
        Advertisement.Banner.Show(Banner);
    }
    */
}
