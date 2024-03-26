using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class vektortavolas : MonoBehaviour
{
    [SerializeField] Vector2 x, y;
    [SerializeField] float result;

    // Start is called before the first frame update
    void OnValidate()
    {
        result = GetDistance(x, y);   
    }

    float GetDistance(Vector2 a, Vector2 b)
    {
        return (a-b).magnitude;
    }
        
  


    // Update is called once per frame
    void Update()
    {
        

    }
}
