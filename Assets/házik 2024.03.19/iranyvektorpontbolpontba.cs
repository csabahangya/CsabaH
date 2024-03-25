using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iranyvektorpontbolpontba : MonoBehaviour
{
    [SerializeField] Vector3 a, b;
    [SerializeField] Vector3 c;

    // Start is called before the first frame update
    void OnValidate()
    {
        c = Mutatas(a, b);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    Vector3 Mutatas(Vector3 a, Vector3 b)
    {
        Vector3 v = a - b;
        return v.normalized;
    }

}
