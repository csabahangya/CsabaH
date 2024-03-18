using UnityEditor.Hardware;
using UnityEngine;

public class repeatHF3 : MonoBehaviour
{
    [SerializeField] int gold, hp;

    [SerializeField] bool buyb, buyt, buyf;

  
    // Update is called once per frame
    void OnValidate()
    {
        int b = 10;
        int t = 4;
        int f = 13;

        int hparany = 5;

        buyb = gold >= b || b * hparany < hp;
        buyt = gold >= t || t * hparany < hp;
        buyf = gold >= f || f * hparany < hp;

    }
}


