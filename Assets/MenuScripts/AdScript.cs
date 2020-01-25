
using UnityEngine;
//using UnityEngine.Monetization;
using UnityEngine.UI;
using GoogleMobileAds.Api;

public class AdScript : MonoBehaviour
{
    /*
    private string StoreIdAndroid = "3047233";
    private string StoreIdiOS = "3047232";

    private string RewardedVideo = "rewardedVideo";
    */
    public Text text;

    public GameObject rewardMenu;
    public GameObject tryMenu;
    public GameObject adNotLoaded;

    //google ads
    public static AdScript instance;
    private string appID;

    private BannerView bannerView;
    private string bannerID = "ca-app-pub-3940256099942544 / 6300978111";

    private InterstitialAd interstitialAd;
    private string interID = "ca-app-pub-3940256099942544/1033173712";



    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
        /*
        if (PlayerPrefs.GetInt("AdPlayed") != 0)
        {
            GameObject.Find("SaveScoreAd").GetComponent<Button>().interactable = false;
        }
        Monetization.Initialize(StoreIdAndroid, false); //kd ke se release game treba da e FALSE
        adNotLoaded.SetActive(false);
        */
    }

    void Start()
    {
        //RequestInterstetial();
        
        adNotLoaded.SetActive(false);    
    }
    
    public void requestBanner()
    {
        bannerView = new BannerView(bannerID, AdSize.Banner, AdPosition.Bottom);

        AdRequest request = new AdRequest.Builder().Build();
        bannerView.LoadAd(request);

        bannerView.Show();
    }

    public void HideBanner()
    {
        bannerView.Hide();
    }

   public void RequestInterstetial()
    {
        interstitialAd = new InterstitialAd(interID);
        AdRequest request = new AdRequest.Builder().Build();

        interstitialAd.LoadAd(request);
    }

    public void ShowInterstetialAd()
    {
        if (interstitialAd.IsLoaded())
        {
            interstitialAd.Show();
        }
        else
        {
            Debug.Log("Fullscren add not loaded");
        }
    }


    /*
    public void StartAd()
    {   
        if (PlayerPrefs.GetInt("AdPlayed") == 0)
        {
            PlayAd();           
        }        
    }
    */
    void Update()
    {
        /*
        if (Monetization.IsReady(RewardedVideo))
        {
            adNotLoaded.SetActive(false);
        }
        */
    }

    /*
    void PlayAd()
    {
        if (Monetization.IsReady(RewardedVideo))
        {
            ShowAdPlacementContent Ad = null;
            Ad = Monetization.GetPlacementContent(RewardedVideo) as ShowAdPlacementContent;

            if (Ad != null)
            {
                Ad.Show(AdFinished);
            }
            else
            {
                adNotLoaded.SetActive(true);
            }
        }
        else
        {
            adNotLoaded.SetActive(true);
        }
    }
    */

 
        /*
    void AdFinished(ShowResult result)
    {
        if (result == ShowResult.Finished)
        {
            int counter = 0;
            int temp = 0;
            counter++;

            tryMenu.SetActive(false);
            rewardMenu.SetActive(true);
            PlayerPrefs.SetInt("savedScore", PlayerPrefs.GetInt("Score"));
            PlayerPrefs.SetInt("Clicked", 1);
            PlayerPrefs.SetInt("Death", 0);
            PlayerPrefs.SetInt("AdPlayed", 1);

            //Extra lives used kod dole
            temp = PlayerPrefs.GetInt("ExtraLives");
            PlayerPrefs.SetInt("ExtraLives", temp + counter);

        }
        else if (result == ShowResult.Skipped)
        {
            tryMenu.SetActive(false);
            text.text = "You score has not been saved because the AD was skipped!";
            rewardMenu.SetActive(true);
            PlayerPrefs.SetInt("Clicked", 1);
            PlayerPrefs.SetInt("Death", 0);
            PlayerPrefs.SetInt("savedScore", 0);
            PlayerPrefs.SetInt("AdPlayed", 0);
        }
        else
        {
            tryMenu.SetActive(false);
            text.text = "Your score has not been saved because the AD could not be loaded!";
            rewardMenu.SetActive(true);
            PlayerPrefs.SetInt("Clicked", 1);
            PlayerPrefs.SetInt("Death", 0);
            PlayerPrefs.SetInt("savedScore", 0);
            PlayerPrefs.SetInt("AdPlayed", 0);
        }
    }
   */
}
