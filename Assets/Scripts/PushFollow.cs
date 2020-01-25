using UnityEngine;


public class PushFollow : MonoBehaviour
{

    public GameObject objectToFollow;

    void FixedUpdate()
    {

        if (objectToFollow != null)
        {
            transform.position = new Vector3(transform.position.x,objectToFollow.transform.position.y - 36f, transform.position.z) * Time.timeScale;
        }

    }

}
