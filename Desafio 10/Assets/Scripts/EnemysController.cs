using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemysController : MonoBehaviour
{

    [SerializeField] GameObject[] enemys;

    // Start is called before the first frame update
    void Start()
    {
        DisableEnemys();
        OneActivate();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void DisableEnemys()
    {
        for (int enemy = 0; enemy < enemys.Length; enemy++)
        {
            enemys[enemy].SetActive(false);
        }
    }

    private void OneActivate()
    {
        int enemyIndex = Random.Range(0, enemys.Length);
        enemys[enemyIndex].SetActive(true);
    }
}
