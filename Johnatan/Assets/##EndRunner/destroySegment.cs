using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroySegment : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log(collision + "Entered");
        if(collision.tag == "despawn")
        {
            Destroy(gameObject);
        }
    }
}
