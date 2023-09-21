using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSegmentGeneration : MonoBehaviour
{
    int currentsegment;
    public GameObject mapStart;
    public GameObject mapSeg1;
    public GameObject mapSeg2;
    public GameObject mapSeg3;
    public GameObject mapSeg4;
    public GameObject mapSeg5;
    //Transform transofromToSpawn;
    //Vector3 locationToSpawn = new Vector3(0, 0, 0);

    private void Start()
    {
        Instantiate(mapStart);
        //transofromToSpawn = gameObject.transform;
        //transofromToSpawn.position = locationToSpawn;

        //generateNewSegement(transofromToSpawn);
    }

    public void generateNewSegement()
    {
        int segmentToGen = Random.Range(0, 4);
        switch (segmentToGen)
        {
            case 0:
                Instantiate(mapSeg1);
                break;
            case 1:
                Instantiate(mapSeg2);
                break;
            case 2:
                Instantiate(mapSeg3);
                break;
            case 3:
                Instantiate(mapSeg4);
                break;
            case 4:
                Instantiate(mapSeg5);
                break;
        }
    }
}
