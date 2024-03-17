using UnityEngine;

public class HF5 : MonoBehaviour
{
    [SerializeField] int a;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i <= a; i++)
        {
            if (i % 3 == 0 && i % 5 != 0)
                Debug.Log("FIZZ");
            {
                if (i % 5 == 0 && i % 3 != 0)
                    Debug.Log("BUZZ");
                {
                    if (i % 3 == 0 && i % 5 == 0)
                        Debug.Log("FIZZBUZZ");
                    {
                        if (i % 3 != 0 && i % 5 != 0)
                            Debug.Log(i);

                    }
                }
            }
        }
    }
}

