using UnityEngine;

public class HF7 : MonoBehaviour
{
    void Start()
    {
        GenerateMultiplicationTable(9, 10);
        
    }

    void GenerateMultiplicationTable(int rows, int columns)
    {
        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= columns; j++)
            {
                int result = i * j;
                Debug.Log(i + " * " + j + " = " + result);
            }
        }
    }
}

