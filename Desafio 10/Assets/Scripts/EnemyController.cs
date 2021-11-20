using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] int enemySpeed = 10;
    [SerializeField] private GameObject player;
    [SerializeField] int distanceEnemy = 0;

    enum Rotacion { Seguimiento = 1, Estatico };
    [SerializeField] private Rotacion movimiento;

    private bool isActive = true;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");

    }

    // Update is called once per frame
    void Update()
    {
        //EnemyDifficulty();

        if(isActive)
        {
            EnemyMovement();
            LookAtPlayer();
        }
        
    }


    void EnemyMovement()
    {
        //transform.position = new Vector3(0, 0, 1) * Time.deltaTime;
        Vector3 direction = (player.transform.position - transform.position).normalized;
        Vector3 direction2 = (player.transform.position - transform.position);
        //Debug.Log(direction2.magnitude);

        if (direction2.magnitude > distanceEnemy)
        {
            transform.position += enemySpeed * direction * Time.deltaTime;
        }

        //Destroy(gameObject, 10f);


    }

    void LookAtPlayer()
    {
        Quaternion newRotation = Quaternion.LookRotation(player.transform.position - transform.position);
        transform.rotation = newRotation;
    }

}
