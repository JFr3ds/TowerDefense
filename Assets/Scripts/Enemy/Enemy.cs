using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float rotationSpeed;
    [SerializeField] int index;

    private void Update()
    {
        MoveEnemy();
    }

    private void MoveEnemy()
    {
        //MoverEnemigo
        transform.Translate(Vector3.forward * (Time.deltaTime * speed));

        //Rotar Enemigo al siquiente punto
        Vector3 targetPoint = new Vector3(Path.Instance.points[index].x, transform.position.y, Path.Instance.points[index].z) - transform.position;
        Quaternion targetRotation = Quaternion.LookRotation(targetPoint, Vector3.up);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * rotationSpeed);

        if (Vector3.Distance(Path.Instance.points[index], transform.position) <= Path.Instance.minDistance)
        {
            if (index < Path.Instance.points.Length - 1)
            {
                index += 1;
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
    }
}
