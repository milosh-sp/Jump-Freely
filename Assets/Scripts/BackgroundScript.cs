using UnityEngine;

public class BackgroundScript : MonoBehaviour
{
    void RandomizeLocation()
    {
        int random1 = Random.Range(-2000, 2000);
        int random2 = Random.Range(-500, -2000);
        transform.position = new Vector3(transform.position.x + random2, transform.position.y + random1, transform.position.z);
    }

    void Start()
    { 
        RandomizeLocation();
    }

}
