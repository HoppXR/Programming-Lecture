using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTest : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space Pressed first time!");
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("Space released!");
        }
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Space held down!");
        }
    }
}
