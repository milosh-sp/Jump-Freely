using UnityEngine;

public class FollowTopScore : MonoBehaviour
{
    public GameObject objectToFollow;

    void Start()
    {
        
    }

  
    void Update()
    {
        if (objectToFollow != null)
        {
            transform.position = new Vector3(transform.position.x, objectToFollow.transform.position.y - 10.50f, transform.position.z);
        }

    }
}
