using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaController : MonoBehaviour
{
    public float bulletSpeed = 10f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Direccion();
        Destruccion();

        //direccion de la bala
        void Direccion()
        {

            transform.Translate(Time.deltaTime * Vector3.forward * bulletSpeed);

        }

        //destruccion de bala
        void Destruccion()
        {
            if (this.transform.position.z < -50 || this.transform.position.z > 50 ||
          this.transform.position.x < -50 || this.transform.position.x > 50)
            {
                Destroy(this.gameObject);
            }
        }
     
    }
}
