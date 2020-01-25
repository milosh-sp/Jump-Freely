using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkinsMenu : MonoBehaviour
{
    public GameObject skinsMenu;
    public GameObject AddPlayer;

    private SpriteRenderer spriteRenderer;
    private static Sprite temp;

    public Text highScoreText;
    public Text extraLivesText;
    public Text timesPlayedText;

    public GameObject activeSkinDefault;
    public GameObject activeSkinPurple;
    public GameObject activeSkinSmoke;
    public GameObject activeSkinSight;
    public GameObject activeSkinWheel;
    public GameObject activeSkinAce;
    public GameObject activeSkinCamo;
    public GameObject activeSkinRedCamo;
    public GameObject activeSkinWinter;
    public GameObject activeSkinDonut;
    public GameObject activeSkinButton;
    public GameObject activeSkinStatic;

    public void OpenMenu()
    {
        skinsMenu.SetActive(true);
    }

    public void CloseMenu()
    {
        skinsMenu.SetActive(false);
    }

    public void ChangeSkin(Sprite newSprite)
    {
        spriteRenderer = AddPlayer.GetComponent<SpriteRenderer>();    
        temp=spriteRenderer.sprite = newSprite;
    } 

    void Awake()
    {
           
        highScoreText.text = "Highscore\n" + PlayerPrefs.GetInt("Highscore").ToString();
        extraLivesText.text = "Extra lives\n" + PlayerPrefs.GetInt("ExtraLives").ToString();
        timesPlayedText.text = "Times Played\n" + PlayerPrefs.GetInt("TimesPlayed").ToString();

     
        if (PlayerPrefs.GetInt("Purple") == 1)
        {
            spriteRenderer = AddPlayer.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = Resources.Load<Sprite>("Purple");

        }
        else if (PlayerPrefs.GetInt("Default") ==1)
        {
            spriteRenderer = AddPlayer.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = Resources.Load<Sprite>("Ball");
        }
        else if (PlayerPrefs.GetInt("Smoke") == 1)
        {
            spriteRenderer = AddPlayer.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = Resources.Load<Sprite>("Smoke");
        }

        else if (PlayerPrefs.GetInt("Sight") == 1)
        {
            spriteRenderer = AddPlayer.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = Resources.Load<Sprite>("Sight");
        }

        else if (PlayerPrefs.GetInt("Wheel") == 1)
        {
            spriteRenderer = AddPlayer.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = Resources.Load<Sprite>("Wheel");
        }
        else if (PlayerPrefs.GetInt("Ace") == 1)
        {
            spriteRenderer = AddPlayer.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = Resources.Load<Sprite>("Ace");
        }
        else if (PlayerPrefs.GetInt("Camo") == 1)
        {
            spriteRenderer = AddPlayer.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = Resources.Load<Sprite>("Camo");
        }
        else if (PlayerPrefs.GetInt("RedCamo") == 1)
        {
            spriteRenderer = AddPlayer.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = Resources.Load<Sprite>("RedCamo");
        }
        else if (PlayerPrefs.GetInt("Winter") == 1)
        {
            spriteRenderer = AddPlayer.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = Resources.Load<Sprite>("Winter");
        }
        else if (PlayerPrefs.GetInt("Donut") == 1)
        {
            spriteRenderer = AddPlayer.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = Resources.Load<Sprite>("Donut");
        }
        else if (PlayerPrefs.GetInt("Button") == 1)
        {
            spriteRenderer = AddPlayer.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = Resources.Load<Sprite>("Button");
        }

        else if (PlayerPrefs.GetInt("Static") == 1)
        {
            spriteRenderer = AddPlayer.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = Resources.Load<Sprite>("Static");
        }

        else
        {
            spriteRenderer = AddPlayer.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = Resources.Load<Sprite>("Ball");
            PlayerPrefs.SetInt("Default", 1);
        }

        //Kd ke se unlocks skins sa dole funkcie posle ovj komentar 
        //Purple 
        if (PlayerPrefs.GetInt("ExtraLives") >= 5) 
        {
            activeSkinPurple.GetComponent<Button>().interactable = true;
            activeSkinPurple.GetComponentInChildren<Text>().text = "Tap to pick";
           
        }
        //Smoke
        if (PlayerPrefs.GetInt("TimesPlayed") >= 10)
        {
            activeSkinSmoke.GetComponent<Button>().interactable = true;
            activeSkinSmoke.GetComponentInChildren<Text>().text = "Tap to pick";

        }
        //Sight
        if (PlayerPrefs.GetInt("Highscore") >= 100)
        {
            activeSkinSight.GetComponent<Button>().interactable = true;
            activeSkinSight.GetComponentInChildren<Text>().text = "Tap to pick";

        }
        //Wheel
        if (PlayerPrefs.GetInt("ExtraLives") >= 10)
        {
            activeSkinWheel.GetComponent<Button>().interactable = true;
            activeSkinWheel.GetComponentInChildren<Text>().text = "Tap to pick";

        }
        //Ace
        if (PlayerPrefs.GetInt("TimesPlayed") >= 50)
        {
            activeSkinAce.GetComponent<Button>().interactable = true;
            activeSkinAce.GetComponentInChildren<Text>().text = "Tap to pick";

        }
        //Camo
        if (PlayerPrefs.GetInt("Highscore") >= 250)
        {
            activeSkinCamo.GetComponent<Button>().interactable = true;
            activeSkinCamo.GetComponentInChildren<Text>().text = "Tap to pick";

        }
        //RedCamo
        if (PlayerPrefs.GetInt("ExtraLives") >= 20)
        {
            activeSkinRedCamo.GetComponent<Button>().interactable = true;
            activeSkinRedCamo.GetComponentInChildren<Text>().text = "Tap to pick";

        }
        //WINTER SS EXTRA LIVES TREBA
        if (PlayerPrefs.GetInt("TimesPlayed") >= 100)
        {
            activeSkinWinter.GetComponent<Button>().interactable = true;
            activeSkinWinter.GetComponentInChildren<Text>().text = "Tap to pick";

        }
        //DONUT TREBA SS EXTRA LIVES
        if (PlayerPrefs.GetInt("Highscore") >= 500)
        {
            activeSkinDonut.GetComponent<Button>().interactable = true;
            activeSkinDonut.GetComponentInChildren<Text>().text = "Tap to pick";

        }
        //Button
        if (PlayerPrefs.GetInt("ExtraLives") >= 50)
        {
            activeSkinButton.GetComponent<Button>().interactable = true;
            activeSkinButton.GetComponentInChildren<Text>().text = "Tap to pick";

        }
        //Static
        if (PlayerPrefs.GetInt("TimesPlayed") >= 250)
        {
            activeSkinStatic.GetComponent<Button>().interactable = true;
            activeSkinStatic.GetComponentInChildren<Text>().text = "Tap to pick";

        }

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
