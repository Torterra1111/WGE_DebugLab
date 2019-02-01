using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoopScript : MonoBehaviour {

    // start for loop 
    public void ExecuteLoop()
    {
        Debug.Log(this);
        int x = 0;

        System.Diagnostics.Stopwatch stopwatch =
            new System.Diagnostics.Stopwatch();
        stopwatch.Start();

        for (int i = 0; i < 500; i++)
        {
            x += i;
           Debug.Log("Value of X = " + x);
        }
        stopwatch.Stop();
        Debug.Log("Time taken:" + (stopwatch.Elapsed));
    }
}


//00:00:05:0393691
//00:00:02.504.... 5000
//00:00:00.2523940 500
//00:00:00.0000033 10

    //Conclusion, To test Logic Errors use debug.log(Thing you want to test) to get
    //an output