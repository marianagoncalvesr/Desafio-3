using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{ 
    [Header("Speed")]
    [Range(0, 10)] public float bulletSpeed = 3f;

    [Header("Damage")]
    public float bulletDamage = 5;

    [Header("Direction")]
    public float bulletDirection;
    
    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        Direction();

        if (this.transform.position.z < -25 || this.transform.position.z > 25 ||
        this.transform.position.x < -25 || this.transform.position.x > 25)
        {
            Destroy(this.gameObject);
        }
    }

  
    void Damage()
    {

    }

    void Direction ()
    {
       transform.Translate(bulletSpeed * Time.deltaTime * Vector3.back *bulletSpeed);
    }
}