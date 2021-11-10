using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyController : MonoBehaviour
{
    [SerializeField] int enemySpeed = 10;
    private GameObject player;
    [SerializeField] int distanceEnemy = 15;

    enum Rotacion { Seguimiento = 1, Estatico };
    [SerializeField] private Rotacion movimiento;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");

    }

    // Update is called once per frame
    void Update()
    {       
        switch (movimiento)
        {
            case Rotacion.Seguimiento:
                LookAtPlayer(); 
                EnemyMovement();            
                break;
            case Rotacion.Estatico:
                LookAtPlayer();
                break;

            default:
                Debug.Log("No se asigno tipo de movimiento");
                break;
        }
    }

    void EnemyMovement()
    {
        Vector3 direction = (player.transform.position - transform.position).normalized;
        Vector3 direction2 = (player.transform.position - transform.position);
        Debug.Log(direction2.magnitude);

        if (direction2.magnitude > distanceEnemy)
        {
            transform.position += enemySpeed * direction * Time.deltaTime;
        }
        
        Destroy(gameObject, 10f);


    }

    void LookAtPlayer()
    {
        Quaternion newRotation = Quaternion.LookRotation(player.transform.position - transform.position);
        transform.rotation = newRotation;
    }
}
