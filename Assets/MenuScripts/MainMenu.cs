
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject menu;
    public GameObject player;

    public bool gamePaused = false;
    private bool ReloadScene = true;
    private bool repeat = false;

    void Awake() 
    {
        PlayerPrefs.SetInt("Score", 0);
        gamePaused = false;
    }

    void Start()
    {

    }

    void Update()  
    {
        if (PlayerPrefs.GetInt("Clicked") == 0 )
        {
            if (ReloadScene)
            {   
                Pause(); 
                ReloadScene = false;     
            }
        }
        else
        {
            if (!repeat)
            {
                Resume();
                repeat = true;
            }
        }
    }

    void Pause()
    {
        menu.SetActive(true);
        Time.timeScale = 0f;
        gamePaused = true;
        
    }

    void Resume()
    { 
        menu.SetActive(false);
        Time.timeScale = 1f;
        player.GetComponent<Movement>().SetTimer();
        gamePaused = false;
    }

    public void Refresh()
    {
        Resume();
    }
}
