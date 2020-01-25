using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickedSkin : MonoBehaviour
{

    public void PickedDefault()
    {
        PlayerPrefs.SetInt("Default", 1);
        PlayerPrefs.SetInt("Purple", 0);
        PlayerPrefs.SetInt("Smoke", 0);
        PlayerPrefs.SetInt("Sight", 0);
        PlayerPrefs.SetInt("Wheel", 0);
        PlayerPrefs.SetInt("Ace", 0);
        PlayerPrefs.SetInt("Camo", 0);
        PlayerPrefs.SetInt("RedCamo", 0);
        PlayerPrefs.SetInt("Winter", 0);
        PlayerPrefs.SetInt("Donut", 0);
        PlayerPrefs.SetInt("Button", 0);
        PlayerPrefs.SetInt("Static", 0);
    }
    public void PickedPurple()
    {
        PlayerPrefs.SetInt("Purple", 1);
        PlayerPrefs.SetInt("Default", 0);
        PlayerPrefs.SetInt("Smoke", 0);
        PlayerPrefs.SetInt("Sight", 0);
        PlayerPrefs.SetInt("Wheel", 0);
        PlayerPrefs.SetInt("Ace", 0);
        PlayerPrefs.SetInt("Camo", 0);
        PlayerPrefs.SetInt("RedCamo", 0);
        PlayerPrefs.SetInt("Winter", 0);
        PlayerPrefs.SetInt("Donut", 0);
        PlayerPrefs.SetInt("Button", 0);
        PlayerPrefs.SetInt("Static", 0);
    }

    public void PickedSmokeSkin()
    {
        PlayerPrefs.SetInt("Smoke",1);
        PlayerPrefs.SetInt("Purple", 0);
        PlayerPrefs.SetInt("Default", 0);
        PlayerPrefs.SetInt("Sight", 0);
        PlayerPrefs.SetInt("Wheel", 0);
        PlayerPrefs.SetInt("Ace", 0);
        PlayerPrefs.SetInt("Camo", 0);
        PlayerPrefs.SetInt("RedCamo", 0);
        PlayerPrefs.SetInt("Winter", 0);
        PlayerPrefs.SetInt("Donut", 0);
        PlayerPrefs.SetInt("Button", 0);
        PlayerPrefs.SetInt("Static", 0);
    }

    public void PickedSightSkin()
    {
        PlayerPrefs.SetInt("Sight",1);
        PlayerPrefs.SetInt("Smoke", 0);
        PlayerPrefs.SetInt("Purple", 0);
        PlayerPrefs.SetInt("Default", 0);
        PlayerPrefs.SetInt("Wheel", 0);
        PlayerPrefs.SetInt("Ace", 0);
        PlayerPrefs.SetInt("Camo", 0);
        PlayerPrefs.SetInt("RedCamo", 0);
        PlayerPrefs.SetInt("Winter", 0);
        PlayerPrefs.SetInt("Donut", 0);
        PlayerPrefs.SetInt("Button", 0);
        PlayerPrefs.SetInt("Static", 0);
    }
    public void PickedWheelSkin()
    {
        PlayerPrefs.SetInt("Wheel", 1);
        PlayerPrefs.SetInt("Sight", 0);
        PlayerPrefs.SetInt("Smoke", 0);
        PlayerPrefs.SetInt("Purple", 0);
        PlayerPrefs.SetInt("Default", 0);
        PlayerPrefs.SetInt("Ace", 0);
        PlayerPrefs.SetInt("Camo", 0);
        PlayerPrefs.SetInt("RedCamo", 0);
        PlayerPrefs.SetInt("Winter", 0);
        PlayerPrefs.SetInt("Donut", 0);
        PlayerPrefs.SetInt("Button", 0);
        PlayerPrefs.SetInt("Static", 0);
    }
    public void PickedAceSkin()
    {
        PlayerPrefs.SetInt("Ace", 1);
        PlayerPrefs.SetInt("Wheel", 0);
        PlayerPrefs.SetInt("Sight", 0);
        PlayerPrefs.SetInt("Smoke", 0);
        PlayerPrefs.SetInt("Purple", 0);
        PlayerPrefs.SetInt("Default", 0);
        PlayerPrefs.SetInt("Camo", 0);
        PlayerPrefs.SetInt("RedCamo", 0);
        PlayerPrefs.SetInt("Winter", 0);
        PlayerPrefs.SetInt("Donut", 0);
        PlayerPrefs.SetInt("Button", 0);
        PlayerPrefs.SetInt("Static", 0);
    }

    public void PickedCamoSkin()
    {
        PlayerPrefs.SetInt("Camo", 1);
        PlayerPrefs.SetInt("Ace", 0);
        PlayerPrefs.SetInt("Wheel", 0);
        PlayerPrefs.SetInt("Sight", 0);
        PlayerPrefs.SetInt("Smoke", 0);
        PlayerPrefs.SetInt("Purple", 0);
        PlayerPrefs.SetInt("Default", 0);
        PlayerPrefs.SetInt("RedCamo", 0);
        PlayerPrefs.SetInt("Winter", 0);
        PlayerPrefs.SetInt("Donut", 0);
        PlayerPrefs.SetInt("Button", 0);
        PlayerPrefs.SetInt("Static", 0);
    }
    public void PickedRedCamoSkin()
    {
        PlayerPrefs.SetInt("RedCamo",1);
        PlayerPrefs.SetInt("Camo", 0);
        PlayerPrefs.SetInt("Ace", 0);
        PlayerPrefs.SetInt("Wheel", 0);
        PlayerPrefs.SetInt("Sight", 0);
        PlayerPrefs.SetInt("Smoke", 0);
        PlayerPrefs.SetInt("Purple", 0);
        PlayerPrefs.SetInt("Default", 0);
        PlayerPrefs.SetInt("Winter", 0);
        PlayerPrefs.SetInt("Donut", 0);
        PlayerPrefs.SetInt("Button", 0);
        PlayerPrefs.SetInt("Static", 0);
    }
    public void PickedWinterSkin()
    {
        PlayerPrefs.SetInt("Winter", 1);
        PlayerPrefs.SetInt("RedCamo", 0);
        PlayerPrefs.SetInt("Camo", 0);
        PlayerPrefs.SetInt("Ace", 0);
        PlayerPrefs.SetInt("Wheel", 0);
        PlayerPrefs.SetInt("Sight", 0);
        PlayerPrefs.SetInt("Smoke", 0);
        PlayerPrefs.SetInt("Purple", 0);
        PlayerPrefs.SetInt("Default", 0);
        PlayerPrefs.SetInt("Donut", 0);
        PlayerPrefs.SetInt("Button", 0);
        PlayerPrefs.SetInt("Static", 0);

    }
    public void PickedDonutSkin()
    {
        PlayerPrefs.SetInt("Donut", 1);
        PlayerPrefs.SetInt("Winter", 0);
        PlayerPrefs.SetInt("RedCamo", 0);
        PlayerPrefs.SetInt("Camo", 0);
        PlayerPrefs.SetInt("Ace", 0);
        PlayerPrefs.SetInt("Wheel", 0);
        PlayerPrefs.SetInt("Sight", 0);
        PlayerPrefs.SetInt("Smoke", 0);
        PlayerPrefs.SetInt("Purple", 0);
        PlayerPrefs.SetInt("Default", 0);
        PlayerPrefs.SetInt("Button", 0);
        PlayerPrefs.SetInt("Static", 0);
    }
    public void PickedButtonSkin()
    {
        PlayerPrefs.SetInt("Button",1);
        PlayerPrefs.SetInt("Donut", 0);
        PlayerPrefs.SetInt("Winter", 0);
        PlayerPrefs.SetInt("RedCamo", 0);
        PlayerPrefs.SetInt("Camo", 0);
        PlayerPrefs.SetInt("Ace", 0);
        PlayerPrefs.SetInt("Wheel", 0);
        PlayerPrefs.SetInt("Sight", 0);
        PlayerPrefs.SetInt("Smoke", 0);
        PlayerPrefs.SetInt("Purple", 0);
        PlayerPrefs.SetInt("Default", 0);
        PlayerPrefs.SetInt("Static", 0);
    }
    public void PickedStaticSkin()
    {
        PlayerPrefs.SetInt("Static", 1);
        PlayerPrefs.SetInt("Button", 0);
        PlayerPrefs.SetInt("Donut", 0);
        PlayerPrefs.SetInt("Winter", 0);
        PlayerPrefs.SetInt("RedCamo", 0);
        PlayerPrefs.SetInt("Camo", 0);
        PlayerPrefs.SetInt("Ace", 0);
        PlayerPrefs.SetInt("Wheel", 0);
        PlayerPrefs.SetInt("Sight", 0);
        PlayerPrefs.SetInt("Smoke", 0);
        PlayerPrefs.SetInt("Purple", 0);
        PlayerPrefs.SetInt("Default", 0);

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
