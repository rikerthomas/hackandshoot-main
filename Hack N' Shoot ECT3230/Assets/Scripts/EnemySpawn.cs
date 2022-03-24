using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemy;
    public Transform enemyPos;
    public bool isDead;
    public GameObject spawner;
    
    
    // Start is called before the first frame update
    void Start()
    {

        
    }

    private void Update()
    {
        
        {
            Destroy(spawner);
            gameObject.GetComponent<BoxCollider>().enabled = false;
            StopCoroutine(SpawnMoreEnemies());
        }
    }

    private void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.tag == "Player")
        {    
            Debug.Log("Enemys are spawnignasignsda");
            StartCoroutine(SpawnMoreEnemies());
        }
    }

    IEnumerator SpawnMoreEnemies()
    {
        while(true)
        {
            yield return new WaitForSeconds(3.0f);
            EnemySpawner();
        }
    }

    private void EnemySpawner()
    {
        Instantiate(enemy, enemyPos.position, enemyPos.rotation);
    }
}
