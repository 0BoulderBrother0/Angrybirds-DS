using UnityEngine;

public class LevelBorderScript : MonoBehaviour
{

    public EnemyManagerScript enemyManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            enemyManager.enemiesAlive--;
        }
        Destroy(collision.gameObject);
    }
}
