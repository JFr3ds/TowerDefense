using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public float rangeDetection;
    public float fireRate;
    float timeRef;

    public float detectingRate;
    float detectingTimeRef;

    public Transform target;

    private void Update()
    {
        UpdateTarget();

        if (target != null)
        {
            Debug.Log("Se encontro un enemigo" + target.name);
        }
    }

    void UpdateTarget()
    {
        if (!target)
        {
            target = OnDetectingEnemy();
        }
        else
        {
            if (Vector3.Distance(target.position, transform.position) > rangeDetection)
            {
                target = null;
            }   
        }
    }

    Transform OnDetectingEnemy()
    {
        for (int i = 0; i < EnemyPool.Instance.enemysPool.Count; i++)
        {
            if (EnemyPool.Instance.enemysPool[i].activeSelf)
            { 
                if (Vector3.Distance(EnemyPool.Instance.enemysPool[i].transform.position, transform.position) <= rangeDetection)
                {
                    return EnemyPool.Instance.enemysPool[i].transform;
                }
            }
        }
        return null;
    }
}
