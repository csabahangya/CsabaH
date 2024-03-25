using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class floorceilround : MonoBehaviour
{
    [SerializeField] float a, b;
    [SerializeField] float floor;

    // Start is called before the first frame update
    void Start()
    {
      floor = Flooor(a, b);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    float Flooor(float x, float y)
    {
        if (x < y)
            return y;
        else
            return x;
    }

  
                
    }

       
