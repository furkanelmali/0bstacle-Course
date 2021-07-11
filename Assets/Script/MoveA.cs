using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveA : MonoBehaviour

{     

    public float MoveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        PrintInstruction();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstruction()
    {
        Debug.Log("Move your character with WASD or Arrow Keys");
    }

    void MovePlayer()
    {   
        float xValue= Input.GetAxis("Horizontal") * Time.deltaTime * MoveSpeed;
        float zValue= Input.GetAxis("Vertical") * Time.deltaTime * MoveSpeed;
        transform.Translate(xValue, 0, zValue);
    }
}
