using UnityEngine;

public class ZebraSpawnerScript : MonoBehaviour
{
    public GameObject zebra;
    public float throwSpeed;

    public float maxVelocity;
    bool isDragging;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0) && isDragging)
        {
            isDragging = false;
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            // Gör om pixlarnas koordinater som täcker skärmen för nuvarande cameran i scenen till unity:s rut system koordinater
            mousePosition.z = 0;

            Vector2 throwVelocity = (transform.position - mousePosition) * throwSpeed;
            if (throwVelocity.magnitude > maxVelocity)
            {
                throwVelocity = throwVelocity.normalized * maxVelocity;
            }

            GameObject newParrot = Instantiate(zebra, new Vector3(transform.position.x, transform.position.y), Quaternion.identity);
            newParrot.GetComponent<Rigidbody2D>().linearVelocity = throwVelocity;
        }
    }

    private void OnMouseDown()
    {
        isDragging = true;
    }
}
