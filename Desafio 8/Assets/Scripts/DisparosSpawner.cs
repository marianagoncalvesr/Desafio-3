using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparosSpawner : MonoBehaviour
{
    public GameObject[] objetoPrefab;
    public Transform arma;
    public static int bulletCount = 0;
    AudioSource disparo;

    // Start is called before the first frame update
    void Start()
    {
        disparo = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        ///Con espacio instanciamos las balas
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (bulletCount < 40) 
            {
                Disparo();
                bulletCount++;
            }
        }
    }

    void Disparo()
    {
       
        int disparoPlayer = Random.Range(0, objetoPrefab.Length);
        Instantiate(objetoPrefab[disparoPlayer], transform.position, transform.rotation);
        disparo.PlayOneShot(disparo.clip);    
    }

}

