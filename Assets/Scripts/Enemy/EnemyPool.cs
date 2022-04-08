using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPool : MonoBehaviour
{
    public static EnemyPool Instance;

    public GameObject prefEnemy;
    public List<GameObject> enemysPool;
    public int ammountEnemys;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }

        CreateEnemy(ammountEnemys);
    }

    void CreateEnemy(int ammount)
    {
        for (int i = 0; i < ammount; i++)
        {
            GameObject go = Instantiate(prefEnemy, this.transform);
            enemysPool.Add(go);
            go.SetActive(false);
        }
    }

    public GameObject GetEnemy()
    {
        for (int i = 0; i < enemysPool.Count; i++)
        {
            if (!enemysPool[i].activeSelf) 
            {
                enemysPool[i].SetActive(true);
                return enemysPool[i];
            }
        }
        CreateEnemy(1);
        enemysPool[enemysPool.Count - 1].SetActive(true);
        return enemysPool[enemysPool.Count - 1]; ;
    }
}
    