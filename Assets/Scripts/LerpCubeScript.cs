using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpCubeScript : MonoBehaviour {

    public GameObject _cube;
    public Vector2 _leftPosition;
    public Vector2 _rightPosition;

    float Lerp(float a, float b, float t)
    {
        return a + (b - a) * t;
    }

    public void StartLerp()
    {
        _cube.transform.position = _leftPosition;
        StartCoroutine(LerpCube());
    }

    IEnumerator LerpCube()
    {
        float t = 0;



        //Stopwatch
        System.Diagnostics.Stopwatch stopwatch =
            new System.Diagnostics.Stopwatch();
        stopwatch.Start();


        while (t < 1)
        {
            float SmoothStart = t * t;
            float SmoothStop = 1 - (1 - t) * (1 - t);

            t += Time.deltaTime;
            Debug.Log(t);
            _cube.transform.position = Vector2.Lerp(_leftPosition, _rightPosition,Lerp(SmoothStart,SmoothStop,t)); //(Smooth start is t * t), (t * t) +((1 - (1 - t) * (1 - t))-(t* t)) *t)
            if (t >= 1)
            {
                _cube.transform.position = _rightPosition;
            }
            yield return null;

            stopwatch.Stop();
            Debug.Log("Time taken:" + (stopwatch.Elapsed));

        }
    }

    //Debug String
    public void PrintDebugString()
    {
        Debug.Log(this.ToString());
    }


    //Cube output positions
    public override string ToString()
    {
        string s;
        s = (_cube ? "Cube positon = " + _cube.transform.position
       : "Cube not instantiated ") + "\n"
        + "Left Position = " + _leftPosition + "\n"
        + "Right Position = " + _rightPosition;
        return s;
    }


}


