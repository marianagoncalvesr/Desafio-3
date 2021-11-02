using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [SerializeField] int playerSpeed = 5;
    [SerializeField] int rotationSpeed = 5;
    public bool pequenio;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        float ejeH = Input.GetAxis("Horizontal");
        float ejeV = Input.GetAxis("Vertical");

        Vector3 playerMovement = new Vector3(ejeH, 0, ejeV);
        playerMovement.Normalize();
        transform.Translate(playerSpeed * Time.deltaTime * playerMovement, Space.World);

        if (playerMovement != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(playerMovement, Vector3.up);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }

    }
    public void ChangeSize()
    {
        Debug.Log("Player cambiando escala");
        if (pequenio == true)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        else
        {
            transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        }
        pequenio = !pequenio;
       
    }
    void OnCollisionEnter(Collision collisionInfo)
    {
        if(!collisionInfo.gameObject.CompareTag("Floor"))
        {
            Debug.Log("Soy un " + this.gameObject.name + " colisionando contra " + collisionInfo.gameObject.name);
    
        }
 

    }
}
