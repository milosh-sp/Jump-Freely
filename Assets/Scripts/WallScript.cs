
using UnityEngine;

public class WallScript : MonoBehaviour
{
    private int random;
    public bool flag;

    public void Randomize()
    {
        random = Random.Range(0, 100);
        
        if(random>60)
        {
            if (this.GetComponentInParent<RandomCounter>().count < 3)
            {
                flag = true;
                this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
                this.GetComponentInParent<RandomCounter>().count++;
            }
            else
            {
                flag = false;
                this.gameObject.GetComponent<SpriteRenderer>().enabled = true;
                this.GetComponentInParent<RandomCounter>().count = 0;
            }

        }
        else
        {
            flag = false;
            this.gameObject.GetComponent<SpriteRenderer>().enabled = true;
            this.GetComponentInParent<RandomCounter>().count = 0;
        }
    }

    void Start()
    {
        random = Random.Range(0, 100);
        if(random<=40)
            Randomize();
    }

}
