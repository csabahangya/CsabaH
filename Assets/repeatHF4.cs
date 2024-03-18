using UnityEngine;

public class repeatHF4 : MonoBehaviour
{
    [SerializeField] int a;
    [SerializeField] int b;

    // Start is called before the first frame update
    void OnValidate()
    {
        b = 0;

        for (int i = 0; i <= a; i++)
        b += i;

    }


}
