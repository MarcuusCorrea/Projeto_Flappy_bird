using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class webcontroller : MonoBehaviour
{

    public float pipeSpeed;

    

    public Player pc;
    
    void Start()
    {
        pc = GameObject.Find("Player").GetComponent<Player>();
    }

   
    void Update()
    {
            if(pc.isAlive == true)
            {
            Vector3 pos = transform.position;
            pos.x = pos.x - pipeSpeed * Time.deltaTime;
            transform.position = pos;

            if(transform.position.x < -5f)
            {
                GameObject.Destroy(gameObject);
            }
    }
}
}