using UnityEngine;
using UnityEngine.SceneManagement;

public class ZebraSpawnerScript : MonoBehaviour
{
    public GameObject[] shots;
    public float throwSpeed;
    int shotsIndex = 0;

    public float maxVelocity;
    bool isDragging;

    GameUiScript gameUI;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameUI = GameObject.FindGameObjectWithTag("GameUI").GetComponent<GameUiScript>();
        gameUI.SetZebrasLeft(shots.Length);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0) && isDragging && shotsIndex < shots.Length)
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

            GameObject newParrot = Instantiate(shots[shotsIndex], new Vector3(transform.position.x, transform.position.y), Quaternion.identity);
            shotsIndex++;
            if (shotsIndex == shots.Length)
            {
                Invoke("ReturnToLevelSelect", 3);
            }
            gameUI.SetZebrasLeft(shots.Length - shotsIndex);
            newParrot.GetComponent<Rigidbody2D>().linearVelocity = throwVelocity;
        }
    }

    private void OnMouseDown()
    {
        isDragging = true;
    }

    void ReturnToLevelSelect()
    {
        SceneManager.LoadScene("Level Select");
    }
}
