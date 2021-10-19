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

    /// <summary>
    /// Crea la bala desde el spawner
    /// </summary>
    void SpawnEnemy()
    {
        int enemyIndex = Random.Range(0, bulletPrefab.Length);
        Debug.Log(enemyIndex);
        Instantiate(bulletPrefab[enemyIndex], transform);
    }
}
