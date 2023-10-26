using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateTest : MonoBehaviour
{
    // Random.Range()
    
    public GameObject[] ball;
    void Start()
    {
        InvokeRepeating("RandomBall", 2f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0)) 
        {
            CancelInvoke("RandomBall");
        }
    }

    void RandomBall()
    {
        int RandNum = Random.Range(0, ball.Length);
        Instantiate(ball[RandNum], transform.position, Quaternion.identity);
    }
}
