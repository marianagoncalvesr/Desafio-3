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
        for (int a = 0; a < enemys.Length; a++)
        {
            enemys[a].SetActive(false);
            //enemys[a].GetComponent<EnemyController>().SetActiveEnemy(false);

            //GetEnemyComponent(enemys[a]).SetActiveEnemy(true);
        }
    }

    private void OneActivate()
    {
        int enemyIndex = Random.Range(0, enemys.Length);

        //enemys[enemyIndex].GetComponent<EnemyController>().SetActiveEnemy(true);
        //GetEnemyComponent(enemys[enemyIndex]).SetActiveEnemy(true);
        enemys[enemyIndex].SetActive(true);

    }

    private EnemyController GetEnemyComponent(GameObject enemy)

    {
        return enemy.GetComponent<EnemyController>();
    }
}
