using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour

{

    public float rotarEnY;
    public float velocidadRotacion;

    void Start()
    { 
        velocidadRotacion = 150;
    }

    // Update is called once per frame
    void Update()
    {
        rotarEnY = Input.GetAxis("Horizontal");
        this.transform.Rotate(Vector3.up * rotarEnY * velocidadRotacion * Time.deltaTime);
    }
    


}