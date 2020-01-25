using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    private Text score;
    private int points = 0;

    void Awake()
    {
        score = GetComponent<Text>();
        points = PlayerPrefs.GetInt("Score");
        
        if(points<0)
        {
            score.text = "0";
        }
        else
        {
            score.text = points.ToString();
        }

    }

    void Start()
    {
       
    }

    void Update()
    {
        points = PlayerPrefs.GetInt("Score");
        if (points < 0)
        {
            score.text = "0";
        }
        else
        {
            score.text = points.ToString();
        }
    } 
}
