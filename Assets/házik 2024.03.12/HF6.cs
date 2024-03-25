using UnityEngine;

public class HF6 : MonoBehaviour
{
    [SerializeField] int a;
    [SerializeField] bool primszam;

    // Start is called before the first frame update
    void OnValidate()
    {
        primszam = true;

        if (a <= 1)
        primszam = false;

        for (int i = 2; i <= a / 2; i++)
        {
            if (a % i == 0)
                primszam = false;






        }
    }
}

