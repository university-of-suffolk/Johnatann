using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapMoving : MonoBehaviour
{
    float amountToMove = 0.01f;
    GameObject GM;
    speedUp SU;

    private void Start()
    {
        GM = GameObject.Find("gameManager");
        SU = GM.GetComponent<speedUp>();
        amountToMove = amountToMove + SU.currrentCount;
    }

    void Update()
    {
        gameObject.transform.position = new Vector3(gameObject.transform.position.x + amountToMove , gameObject.transform.position.y, gameObject.transform.position.z);
    }
}
