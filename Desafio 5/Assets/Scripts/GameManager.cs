using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    AudioSource ambiente;

    // Start is called before the first frame update
    void Start()
    {
        ambiente = GetComponent<AudioSource>();
        ambiente.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
