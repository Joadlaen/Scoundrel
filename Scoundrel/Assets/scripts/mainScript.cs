using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        System.Random D6Rand = new System.Random();
        int dSix = D6Rand.Next(1, 6);
        Debug.Log(dSix);




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
