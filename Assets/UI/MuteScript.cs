using UnityEngine;
using UnityEngine.UI;

public class MuteScript : MonoBehaviour
{
    private bool mute;

    private Text text;

    void Awake()
    {
        text = GetComponentInChildren<Text>();

    }

    void Start()
    {

    }

    void Update()
    {
      
    }

    public void Mute()
    {
        mute =! mute;
        AudioListener.volume = mute ? 0 : 1;
        if (mute)
        {
            Unmute();   
        }
        else
        {  
            MuteSound(); 
        }
    }

    void Unmute()
    {
        text.text = "UNMUTE SOUND";
    }

    void MuteSound()
    {
        text.text = "MUTE SOUND";
    }
}
