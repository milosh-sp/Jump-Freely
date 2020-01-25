
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public float velocity;
    private float step;
    private int score;
    private int modul = 5;
    private int previousScore=0;
    private int savedScore;
    
    void Start()
    {
        velocity = 0f;
        step = 0.20f;
        modul = 5;
        score = 0;
        if(PlayerPrefs.GetInt("Score")!=0)
            savedScore = PlayerPrefs.GetInt("Score");
        else
            savedScore = PlayerPrefs.GetInt("savedScore");

        Screen.SetResolution(Screen.width, Screen.height, true);
    }

    void Update()
    {
        if (PlayerPrefs.GetInt("AdPlayed") == 0)
        {
            score = PlayerPrefs.GetInt("Score");
        }
        else
        {
            score = PlayerPrefs.GetInt("Score") - savedScore;
        }

        if (score % modul == 0 && score != previousScore && score<300)
        {
     
            step += 0.01f;

            if (score>=50)
                modul = 10;
            if (score >= 100)
                modul = 20;

            previousScore = score;
        }

        transform.position = new Vector3(transform.position.x, velocity, transform.position.z);
        velocity += step * Time.timeScale;
    }
    
}
