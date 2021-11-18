using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] int enemySpeed = 10;
    [SerializeField] int distanceEnemy = 15;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        RaycastEnemy();
    }

    private void RaycastEnemy()
    {
        RaycastHit hit;

        if (Physics.Raycast(this.transform.position, this.transform.TransformDirection(Vector3.forward), out hit, 30f))

        {
            Debug.Log("Look at");
            LookAtPlayer();

        }
    }

    private void OnDrawGizmos()

    {
        Gizmos.color = Color.red;

        Gizmos.DrawRay(this.transform.position, this.transform.TransformDirection(Vector3.forward) * 30f);

    }



    void LookAtPlayer()
    {
        Quaternion newRotation = Quaternion.LookRotation(player.transform.position - transform.position);
        transform.rotation = newRotation;
    }
}
