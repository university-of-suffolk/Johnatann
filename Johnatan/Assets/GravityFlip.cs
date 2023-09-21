using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityFlip : MonoBehaviour
{

    private Rigidbody2D rb;
    public float gravity;
    
    private bool Canpress = true;


    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector3(0, gravity, 0);
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") && Canpress)
        {
            rb.velocity = new Vector3(0, (gravity *= -1), 0);
            Canpress = false;
            StartCoroutine(GravityDelay());
        }

    }

    IEnumerator GravityDelay()
    {
        yield return new WaitForSeconds(0.1f);
        Canpress = true;
    }
}
