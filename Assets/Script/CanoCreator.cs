using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanoCreator : MonoBehaviour
{
    [SerializeField]
    private GameObject canoBase;
    private float TimeToCreate = 5f;
    public float Range =2f;

    float clock;

    void Update()
    {
        clock += Time.deltaTime; //contagem
        if (clock >= TimeToCreate)
        {
            clock = 0;
            Vector3 pos = transform.position;
            pos.y = pos.y - UnityEngine.Random.Range(-Range, Range);  //(randon tem função de variar os numeros)
            GameObject.Instantiate(canoBase, pos, Quaternion.identity);
        }
    }
}
 
