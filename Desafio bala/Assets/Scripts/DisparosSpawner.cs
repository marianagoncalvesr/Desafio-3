using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparosSpawner : MonoBehaviour
{
    public GameObject[] objetoPrefab;
    public Transform arma;
    public static int bulletCount = 0;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        ///Con espacio instanciamos las balas
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (bulletCount < 15) 
            {
                Disparo();
                bulletCount++;
            }
        }
    }

    void Disparo()
    {
       
        int disparoPlayer = Random.Range(0, objetoPrefab.Length);
        Debug.Log(disparoPlayer);
        //Instantiate(objetoPrefab[disparoPlayer], pistola.position, pistola.rotation);
        Instantiate(objetoPrefab[disparoPlayer], transform.position, transform.rotation);
    }

}

