using UnityEngine;

public class FollowCameraMute : MonoBehaviour
{

    public GameObject objectToFollow;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (objectToFollow != null)
        {
            transform.position = new Vector3(transform.position.x, objectToFollow.transform.position.y - -26.70f, transform.position.z);
        }


    }
}
