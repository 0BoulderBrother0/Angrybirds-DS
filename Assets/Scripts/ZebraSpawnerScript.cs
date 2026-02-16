using UnityEngine;

public class ZebraSpawnerScript : MonoBehaviour
{
    public GameObject zebra;
    public Vector2 throwSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            // Gör om pixlarnas koordinater som täcker skärmen för nuvarande cameran i scenen till unity:s rut system koordinater
            newPosition.z = 0;

            GameObject newParrot = Instantiate(zebra, newPosition, Quaternion.identity);
            newParrot.GetComponent<Rigidbody2D>().linearVelocity = throwSpeed;
        }
    }
}
