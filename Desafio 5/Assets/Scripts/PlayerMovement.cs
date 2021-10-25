using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speedPlayer = 0.5f;
    public GameObject camaraActivate;
    Vector3 personajeLimite = new Vector3(-0f, 1.8f - 12f);
    AudioSource steps;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(-14f, 1.8f, -12f);
        steps = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //Movement();
    }

    private void LateUpdate()
    {
        Movement();
    }

    //Movimiento del personaje
    void Movement()
    {
        float ejeHorizontal = Input.GetAxis("Horizontal");
        float ejeVertical = Input.GetAxis("Vertical");

        Vector3 movementPlayer = new Vector3(ejeHorizontal, 0, ejeVertical);
        transform.Translate(speedPlayer * Time.deltaTime * movementPlayer, Space.World);


        if (movementPlayer != Vector3.zero)
        {
            transform.forward = movementPlayer;
            if (steps.isPlaying == false)
            {
                steps.Play();
            }
            
        }
        else 
        {
            steps.Stop();
        }



    }
}
