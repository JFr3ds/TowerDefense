using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float rotationSpeed;
    [SerializeField] int actualIndex;
    
    

    private void Update()
    {
        MoveEnemy();
    }

    private void MoveEnemy()
    {
        //MoverEnemigo
        transform.Translate(Vector3.forward * (Time.deltaTime * speed));

        //Rotar Enemigo al siquiente punto
        Vector3 targetPoint = new Vector3(Path.Instance.points[0].x, transform.position.y, Path.Instance.points[0].z) - transform.position;
        Quaternion targetRotation = Quaternion.LookRotation(targetPoint, Vector3.up);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * rotationSpeed);
    }
}
