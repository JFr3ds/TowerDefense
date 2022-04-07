using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemys : MonoBehaviour
{
    public GameObject prefEnemy;
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
        GameObject go = Instantiate(prefEnemy, Path.Instance.points[0], Quaternion.identity);
    }
}
