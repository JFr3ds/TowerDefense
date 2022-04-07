using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerCreator : MonoBehaviour
{
    public GameObject prefTower;
    public int towersCreated;

    private void OnMouseDown()
    {
        if(towersCreated > 0)
        { 
            CreateTower();
            towersCreated--;
        }
    }

    private void CreateTower()
    {
        GameObject go = Instantiate(prefTower, transform.position, Quaternion.identity);
    }
}
