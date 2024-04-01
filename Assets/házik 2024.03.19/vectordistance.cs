using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class vectordistance : MonoBehaviour
{
    [SerializeField] Vector2 x, y;
    [SerializeField] float result;
    
    void OnValidate()
    {
        result = Distance(x, y);   
    }

    float Distance(Vector2 a, Vector2 b)
    {
        return (a - b).magnitude;

    }
        
}
