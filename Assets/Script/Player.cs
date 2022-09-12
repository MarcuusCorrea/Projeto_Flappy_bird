using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    public float force = 100f;
    public bool isAlive = true;
    public int pointe;

    public TMP_Text pointText;
    
    AudioSource pointeSoud;
    AudioSource hitSound;
    AudioSource wingSound;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        wingSound = GetComponents<AudioSource>()[0];
        hitSound = GetComponents<AudioSource>()[1];
        pointeSoud = GetComponents<AudioSource>()[2];
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space) && isAlive == true)
       {
         rb.AddForce(new Vector2(x:0, y:force));
         wingSound.Play();
       }
        }


    // Update is called once per frame
    void FixedUpdate()
    {


        if(rb.velocity.y > 0)

        {
            transform.rotation = Quaternion.Euler(x:0, y:0, z:45);
        } else if (rb.velocity.y < 0)
        {
            transform.rotation = Quaternion.Euler(x:0, y:0, z:-45);
        }   else 
        {
            transform.rotation = Quaternion.Euler(x:0, y:0, z:0);
        }
    }



    void OnCollisionEnter2D(Collision2D playerCol){
            if (playerCol.transform.CompareTag("pipe") || playerCol.gameObject.name == "ground")
            {
                isAlive = false;
                hitSound.Play();
            }
    }
    void OnTriggerExit2D(Collider2D other ){
            if (other.CompareTag("pipe") )
            {
                pointe = pointe + 1;
                pointText.text = pointe.ToString();
                Debug.Log("passou!");
                pointeSoud.Play();
            }
}
}