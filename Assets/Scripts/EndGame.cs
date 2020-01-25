using UnityEngine;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
    public GameObject going;
    public GameObject Dialog;
    public Text text;
    
    void Start()
    {
        if(PlayerPrefs.GetInt("Highscore")==0)
        {
            PlayerPrefs.SetInt("Highscore", 0);
        }
    }
    
    void Update()
    {
        if (going != null)
        {
            Vector3 newPositon = new Vector3(transform.position.x,
                                             going.transform.position.y - 0f, transform.position.z);
            transform.position = newPositon;
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            Dialog.SetActive(true);

            if(PlayerPrefs.GetInt("Score")>PlayerPrefs.GetInt("Highscore"))
            {
                PlayerPrefs.SetInt("Highscore", PlayerPrefs.GetInt("Score"));
            }

            text.text = text.text = "SCORE: " + PlayerPrefs.GetInt("Score") + "\nHIGHSCORE: " + PlayerPrefs.GetInt("Highscore");


            PlayerPrefs.SetInt("Death",1);

        }

    }

}
