using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clampfüggvény : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    float Clamp(float a, float min, float max)
    {
        if (a <= min)
            return min;
        if (a >= max) 
            return max;
        return a;

    }
}
