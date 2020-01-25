using UnityEngine;

public class FollowScoreCamera : MonoBehaviour
{
    public GameObject objectToFollow;

    void Start()
    {

    }

    void Update()
    {
        if (objectToFollow != null)
        {
            transform.position = new Vector3(transform.position.x, objectToFollow.transform.position.y + 0f, transform.position.z);
        }

    }
}
