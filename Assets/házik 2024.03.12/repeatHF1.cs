using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class repeatHF1 : MonoBehaviour
{
    [SerializeField] int a, b ,c ;

    void OnValidate()
    {
        c = a + b ;
        float sum = a + b ;
        string text = $"{a}+{b}={sum}";
            Debug.Log(text) ;



    }
}
