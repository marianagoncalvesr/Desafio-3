using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonControler : MonoBehaviour
{
    [SerializeField] private GameObject shootOrigen;
    float distanciaRay = 10f;

    [SerializeField] private int shootCooldown = 2;
    [SerializeField] private float timeShoot = 2f;

    [SerializeField] private GameObject bullet;

    private bool canShoot = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (canShoot)
        {
            RaycastCannon();
        }
        else
        {
            timeShoot += Time.deltaTime;
        }

        if (timeShoot > shootCooldown)
        {
            canShoot = true;
        }
    }

    private void FixedUpdate()
    {
        transform.Rotate(0f, 1f, 0f * Time.deltaTime);
    }

    private void RaycastCannon()
    {
        RaycastHit hit;

        if (Physics.Raycast(shootOrigen.transform.position, shootOrigen.transform.TransformDirection(Vector3.forward), out hit, distanciaRay))

        {
            Debug.Log("Disparo");
            canShoot = false;
            timeShoot = 0;
            GameObject bullets = Instantiate(bullet, shootOrigen.transform.position, shootOrigen.transform.rotation);
            
        }
    }

    private void OnDrawGizmos()

    {
        Gizmos.color = Color.blue;

        Gizmos.DrawRay(shootOrigen.transform.position, shootOrigen.transform.TransformDirection(Vector3.forward) * 30f);

    }


}
