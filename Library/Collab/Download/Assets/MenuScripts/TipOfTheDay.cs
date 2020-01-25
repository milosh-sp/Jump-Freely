using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TipOfTheDay : MonoBehaviour
{
    public Text text;
    private string[] TipDataBase = 
        {
        "Jump freely is actually free",
        "Battle royale DLC coming soon",
        "Don't drink and play",
        "Ghflskhu ph!",
        "Be sure to have your phone charged",
        "You should be studying",
        "Wait till I get my score right",
        "Great minds discuss jump freely tactics", 
        "Success is how high you bounce when you hit bottom",
        "It does not matter how slowly you go", 
        "Loot boxes are not included",
        "Microtransactions are not included",
        "Welcome. Welcome to Jump Freely. You have chosen, or been chosen",
        "Do what is right, Jumper. Jump.",
        "Hey catch me later I will tell you my score",
        "Jump Freely does not have special dances, yet",
        "Are you ready kids? Jump jump captain",
        "Houston we have a Jumper",
        "We won't nerf this",
        "Do a jump roll",
        "Shut up clock in and jump up",
        "The jumps Mason what do they mean",
        "Every journey begins with the first jump",
        "It's jump noon",
        "Stay awhile and jump",
        "Not all who jump are lost",
        "One can never have enough jumps",
        "You will not laugh! You will not cry!",
        "You shall not fall",
        "Every flight begins with a fall",
        "Ran of the jump twice",
        "Ask your local fast food restaurant for Jump Burger",
        "The best jump is yet to come free",
        "Doing your jump, doing, doing your jump",
        "These jumps ain't loyal",
        "Now watch me jump, now watch me jump freely",
        "Get protective glass for your phone",
        "Jump freely made me do it",
        "Balling out with my bros"
    };

    void Awake()
    {
        int num = Random.Range(0, TipDataBase.Length);
        text.text = "\n \n" + TipDataBase[num];
    }
  
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
