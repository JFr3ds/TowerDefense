using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemys : MonoBehaviour
{
    public float timeToSpawn;
    float timeRef;
    public int enemyAmmount;
    

    private void Update()
    {
        timeRef += Time.deltaTime;
        if (timeRef >= timeToSpawn && enemyAmmount > 0)
        {
            CreateEnemy();
            timeRef = 0;
            enemyAmmount--;
        }
    }

    void CreateEnemy()
    {
        GameObject enemy = EnemyPool.Instance.GetEnemy();
        enemy.transform.position = Path.Instance.points[0];
    }
}
