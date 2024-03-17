using UnityEngine;

public class HF4 : MonoBehaviour
{
    [SerializeField] int number;
    [SerializeField] int szumma;

    // Start is called before the first frame update
    void OnValidate()
    {
        szumma = 0;
        for (int i = 1; i <= number; i++)
            szumma += i;
        


    }

  
}
