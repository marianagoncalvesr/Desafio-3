using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] bulletPrefab;
    public Transform cannon;
    
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemy();
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
        Instantiate(bulletPrefab[enemyIndex], cannon.position, cannon.rotation);        
    }
}
