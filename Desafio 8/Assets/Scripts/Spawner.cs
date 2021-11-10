using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] enemys;
    enum Difficulties { Easy = 1, Normal, Hard };
    [SerializeField] private Difficulties difficulty;

    // Start is called before the first frame update
    void Start()
    {
  
        switch (difficulty)
        {
            case Difficulties.Easy:
                InvokeRepeating("SpawnerController", 5f, 5f);
                break;

            case Difficulties.Normal:
                InvokeRepeating("SpawnerController", 3f, 3f);
                break;

            case Difficulties.Hard:
                InvokeRepeating("SpawnerController", 1f, 1f);
                break;

            default:
                Debug.Log("No se asigno nivel");
                break;

        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnerController()
    {
        int enemyIndex = Random.Range(0, enemys.Length);
        Instantiate(enemys[enemyIndex], transform.position, transform.rotation);
    }
}
