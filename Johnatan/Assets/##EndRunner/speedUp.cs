using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedUp : MonoBehaviour
{
    public float currrentCount = 0f;

    public void countIncrease()
    {
        currrentCount = currrentCount + 0.0002f;
    }
}
