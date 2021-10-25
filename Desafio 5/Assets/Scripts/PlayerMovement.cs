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
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(-14f, 1.8f, -12f);
        steps = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
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
        ejeHorizontal = Input.GetAxis("Horizontal");
        ejeVertical = Input.GetAxis("Vertical");

        Vector3 movementPlayer = new Vector3(0, 0, ejeVertical);
        //transform.Translate(speedPlayer * Time.deltaTime * movementPlayer, Space.World);
        this.transform.Rotate(Vector3.up * ejeHorizontal * 50 * Time.deltaTime);

        if (Input.GetKey(KeyCode.W))
        {
            transform.localPosition += Vector3.forward * Time.deltaTime * speedPlayer;
        }

        //rb.AddForce(this.transform.forward * ejeVertical);

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
