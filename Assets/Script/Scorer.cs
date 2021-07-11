using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    public int score;
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Hit")
        {

        }
        else
        {
            score++;
            Debug.Log("You hit into a thing this many time:" + score);
        }
                       
    }
}
