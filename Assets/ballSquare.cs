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
        

        

        if (ctn == 0)
        {
            transform.Translate(0, 0, 0);
            Thread.Sleep(2000);
            transform.Translate(0, 8, 0);
            //Thread.Sleep(2000);           //Sets The Speed The Ball Travels at
            //transform.Rotate(0, 0, 90);
            //Thread.Sleep(2000);
            //transform.Translate(0, 1, 0);

        }
    }
}

