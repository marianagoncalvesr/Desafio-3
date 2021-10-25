using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speedPlayer = 0.5f;
    public GameObject camaraActivate;
    Vector3 personajeLimite = new Vector3(-0f, 1.8f - 12f);
    AudioSource steps;
    float ejeHorizontal;
    float ejeVertical;
    public float velocidadRotacion = 100f;

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
        Vector3 movementPlayer = new Vector3(0, 0, 0);
        transform.Translate(speedPlayer * Time.deltaTime * movementPlayer, Space.World);
        this.transform.Rotate(Vector3.up * ejeHorizontal * velocidadRotacion * Time.deltaTime);
        
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * Time.deltaTime * speedPlayer;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += transform.forward * -1 * Time.deltaTime * speedPlayer;
        }

        

        if (ejeVertical != 0)
        {
            //transform.forward = movementPlayer;
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
