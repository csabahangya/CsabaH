using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class vectordistance : MonoBehaviour
{
    Vector3 DistanceAB(Vector3 a, Vector3 b)
    {
        return (b - a).normalized;

    }
        
}
