
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void Load()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
    }
}
