using UnityEngine;

public class circle : MonoBehaviour
{
    [SerializeField] float radius;
 
    void Start()
    {
        float pi = Mathf.PI;
        float k = 2 * radius * pi;
        float t = radius * radius * pi;

        Debug.Log("Ker�let: " + k);
        Debug.Log("Ter�let: " + t);

    }
  
}
