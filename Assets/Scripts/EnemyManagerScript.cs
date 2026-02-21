using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyManagerScript : MonoBehaviour
{

    public int enemiesAlive;
    public float returnToLevelSelectDelay = 5;
    bool clearedLevel = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        enemiesAlive = GameObject.FindGameObjectsWithTag("Enemy").Length;  
    }

    // Update is called once per frame
    void Update()
    {
        if (enemiesAlive == 0 && clearedLevel == false)
        {
            clearedLevel = true;
            Invoke("ReturnToLevelSelect", returnToLevelSelectDelay);
        }
    }

    void ReturnToLevelSelect()
    {
        SceneManager.LoadScene("Level Select");
    }
}
