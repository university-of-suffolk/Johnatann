using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnSegment : MonoBehaviour
{
    //Transform transofromToSpawn;
    //Vector3 locationToSpawn = new Vector3(-20, 0, 0);
    bool canSpawn = true;
    private void Start()
    {
        //transofromToSpawn = gameObject.transform;
        //transofromToSpawn.position = locationToSpawn;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        //Debug.Log(collision + "Exited");
        if (collision.tag == "spawn" && canSpawn)
        {
            GameObject gameManager = GameObject.Find("gameManager");
            RandomSegmentGeneration RSG;
            RSG = gameManager.GetComponent<RandomSegmentGeneration>();
            RSG.generateNewSegement();
            gameManager.GetComponent<speedUp>().countIncrease(); 
            canSpawn = false;
        }
    }
}
