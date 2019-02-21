using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public Enemy enemy;
    public float EnemySpawneRate;
    public int maxEnemySameTime;
    float nextEnemy;
    

    private void Start()
    {
        EnemySpawneRate = 1.5f;
    }

    private void Update()
    {
        int enemyesInScene = GameObject.FindGameObjectsWithTag("Enemy").Length;
        if (
            enemyesInScene < maxEnemySameTime &&
            Time.time > nextEnemy
            )
        {
            InstantiateEnemy();
            nextEnemy = EnemySpawneRate + Time.time;
        }
    }
    // instantiate an Enemy in a random position 
    public void InstantiateEnemy()
    {
        // set enemy type
        RandomEnemy();
        // random position
        Vector3 position = new Vector3(
            Random.Range(-4, 4),
            Random.Range(-2, 4),
            0
            );
        // instantiate
        Instantiate(enemy, position,Quaternion.identity);
    }
    // set enemy type with low oddes for special enemyes 
    private void RandomEnemy()
    {
        int random = Random.Range(0, 10);
        switch (random)
        {
            case 0:
                enemy.SetEnemyTag("HealthEnemy");
                break;
            case 1:
                enemy.SetEnemyTag("ShieldEnemy");
                break;
            case 2:
                enemy.SetEnemyTag("FireRateEnemy");
                break;
            default:
                enemy.SetEnemyTag("Enemy");
                break;
        }

    }
}
