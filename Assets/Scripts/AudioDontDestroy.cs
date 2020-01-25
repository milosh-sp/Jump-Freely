using UnityEngine;

public class AudioDontDestroy : MonoBehaviour
{
    private AudioSource audioData;
    static bool started = false;
    void Awake()
    {
        if (!started)
        {
            audioData = GetComponent<AudioSource>();
            audioData.loop = true;
            audioData.Play(0);
            DontDestroyOnLoad(this);
            started = true;


            PlayerPrefs.SetInt("Clicked", 0);
            PlayerPrefs.SetInt("Death", 0);
            PlayerPrefs.SetInt("Tries", 0);
            PlayerPrefs.SetInt("savedScore", 0);
            PlayerPrefs.SetInt("AdPlayed", 0);
            PlayerPrefs.SetInt("Score", 0);
        }



    }

}
