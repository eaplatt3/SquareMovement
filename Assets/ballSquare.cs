//////////////////////////////
//Earl Platt III
//BCS 427 - Game Programming
//4/1/2019
//Ball Square
//Ball Moves In a Square
/////////////////////////////

using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ballSquare : MonoBehaviour
{
    private int ctn = 0;
    
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        //Statment that moves the ball in a Square 
        if (ctn == 0)
        {
            transform.Translate(0, 0, 0);
            Thread.Sleep(2000);            //Sets The Speed The Ball Travels at
            transform.Translate(0, 5, 0);
            Thread.Sleep(2000);           //Sets The Speed The Ball Travels at
            transform.Rotate(0, 0, -90);
        }        
    }
}

