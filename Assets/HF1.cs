using UnityEngine;

public class HF1 : MonoBehaviour
{
    [SerializeField] int a;
    [SerializeField] int b;
    [SerializeField] int c;


    // Update is called once per frame
    void Update()
    {
        int c = a + b;
        string text = $"{a} + {b} = {c}";

        bool presskey = Input.anyKeyDown;
        if (presskey)
       
            Debug.Log(text);
    }
    void OnValidate()
    {
        c = a + b;
    }
}
