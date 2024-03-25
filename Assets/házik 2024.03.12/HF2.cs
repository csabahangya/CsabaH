using UnityEngine;

public class HF2 : MonoBehaviour
{
    [SerializeField] float a;
    [SerializeField] float b;
    [SerializeField] float c;
    [SerializeField] bool d;
    


    // Start is called before the first frame update
    void OnValidate()
    {

        d = a * a + b * b == c * c;



    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
