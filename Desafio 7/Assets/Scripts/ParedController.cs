using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParedController : MonoBehaviour
{
    private float waitTime = 2f;
    private float timer = 0f;
    [SerializeField] GameObject[] positions;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionStay(Collision collisionInfo)
    {


        if (collisionInfo.gameObject.CompareTag("Player"))
        {
            timer += Time.deltaTime;

            if(timer > waitTime)
            {
                GameObject aux = SelectRandomPosition();
                transform.position = aux.transform.position;
                transform.rotation = aux.transform.rotation;
                timer = 0f;
            }
        }
    }
    private GameObject SelectRandomPosition()
    {
        int num = Random.Range(0, 3);
        return positions[num];
    }
}
