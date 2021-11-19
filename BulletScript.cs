using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown ("space"))
        {
            GameObject bullet1 = Instantiate(bullet);
        }

    }
}
