using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] bulletPrefab;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 2f, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void SpawnEnemy()
    {
        int enemyIndex = Random.Range(0, bulletPrefab.Length);
        Debug.Log(enemyIndex);
       //Instantiate(bulletPrefab[enemyIndex], transform.position, bulletPrefab[enemyIndex].transform.rotation); //La bala se mueve a su direccion
       Instantiate(bulletPrefab[enemyIndex], transform); // La bala se mueve a la direccion del spawner

    }
}
