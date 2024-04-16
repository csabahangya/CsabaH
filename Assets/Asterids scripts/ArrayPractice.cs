using UnityEngine;

public class ArrayPractice : MonoBehaviour
{
    [SerializeField] int[] numbers;
    [SerializeField] int max;

    void OnValidate()
    {
        max = int.MinValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
                max = numbers[i];
        }
    }
}