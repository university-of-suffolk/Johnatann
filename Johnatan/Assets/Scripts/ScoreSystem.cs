using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreSystem : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI scoreText;


    private float currentScore = 0;
    private float distance = 1f;
    private float scoreMultiplier = 1.4f;
    public LayerMask obstMask;
    public GameObject upPoint, downPoint;

    private void Update()
    {
        RaycastHit2D hitUp = Physics2D.Raycast(upPoint.transform.position, Vector2.up, obstMask);
        RaycastHit2D hitDown = Physics2D.Raycast(downPoint.transform.position, -Vector2.up, obstMask);

        if (hitUp)
        {
            if (hitUp.distance < hitDown.distance)
            {
                if (hitUp.distance < 1)
                {
                    StartCoroutine(delay());
                   // currentScore += 50;

                    if (hitUp.distance < 0.1)
                    {
                        currentScore *= scoreMultiplier;
                    }
                }
            }

        }
        
        if(hitDown)
        {
          
            if (hitDown.distance < 1)
            {
                //currentScore += 50;
                StartCoroutine(delay());

                if (hitDown.distance < 0.1)
                {
                    currentScore *= scoreMultiplier;
                }
            }
        }
        


        //Display score txt
        scoreText.text = "Score: " + currentScore;


    }

    IEnumerator delay()
    {
        currentScore += 1;
        yield return new WaitForSeconds(1f);
      
    }

    
    
}

