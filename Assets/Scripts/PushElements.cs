
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PushElements : MonoBehaviour
{
    public GameObject Dialog;
    public Text text;

    void Start()
    {
        if (PlayerPrefs.GetInt("Highscore") == 0)
        {
            PlayerPrefs.SetInt("Highscore", 0);
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "LeftWall" || coll.gameObject.tag == "RightWall")
        {
            Vector3 newPositon = new Vector3(coll.gameObject.transform.position.x,
                                             coll.gameObject.transform.position.y + 81f, coll.gameObject.transform.position.z);
            coll.gameObject.transform.position = newPositon;
            coll.gameObject.GetComponent<WallScript>().Randomize();
        } 

        if(coll.gameObject.tag == "Floor")
        {
            Vector3 newPositon = new Vector3(coll.gameObject.transform.position.x,
                                            coll.gameObject.transform.position.y + 81f, coll.gameObject.transform.position.z);
            coll.gameObject.transform.position = newPositon;
            coll.gameObject.GetComponent<FloorScript>().isScoreSet = false;
        }

        if(coll.gameObject.tag == "Player")
        {

            Dialog.SetActive(true);

            if (PlayerPrefs.GetInt("Score") > PlayerPrefs.GetInt("Highscore"))
            {
                PlayerPrefs.SetInt("Highscore", PlayerPrefs.GetInt("Score"));
            }

            text.text = text.text = "SCORE: " + PlayerPrefs.GetInt("Score") + "\nHIGHSCORE: " + PlayerPrefs.GetInt("Highscore");

            PlayerPrefs.SetInt("Death",1);

        }

    }
}
