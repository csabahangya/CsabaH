using UnityEngine;

public class ControlStructures : MonoBehaviour
{

    void Start()
    {
        for (int i = 1; i <= 100; i++)
        {
            int r = i % 2;
            if (r == 1)

                Debug.Log(i);

        }
    }
}