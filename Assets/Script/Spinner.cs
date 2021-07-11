using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    
    [SerializeField] float valueY = 0f;


    // Start is called before the first frame update
    void Start()
    {
        valueY = valueY * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        
         transform.Rotate(0,valueY,0);
    }
}
