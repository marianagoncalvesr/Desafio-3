using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalController : MonoBehaviour
{
    private GameObject Player;
    public playerMovement Escala;
    private float waitTime = 0.5f;
    private float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
    }

    private void OnTriggerExit(Collider other)
    {
        

        if (other.gameObject.CompareTag("Player") && timer > waitTime)
        {
            other.gameObject.GetComponent<playerMovement>().ChangeSize();
            timer = 0;
        }


    }


}
