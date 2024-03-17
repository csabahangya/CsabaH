using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class repeatHF2 : MonoBehaviour
{
    [SerializeField] int a, b, c;
    [SerializeField] bool pita;

    // Update is called once per frame
    void OnValidate()
    {
        pita = c*c==a*a+b*b;

            

    }
}
