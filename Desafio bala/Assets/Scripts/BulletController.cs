using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{ 
    [Header("Speed")]
    [Range(0, 20)] public float bulletSpeed = 7f;

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

        if (this.transform.position.z < -30 || this.transform.position.z > 30 ||
        this.transform.position.x < -30 || this.transform.position.x > 30)
        {
            Destroy(this.gameObject);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.localScale += new Vector3(2f, 2f, 2f);
        }
    }


    void Damage()
    {

    }

    void Direction ()
    {
       transform.Translate(Time.deltaTime * Vector3.back *bulletSpeed);
    }
}