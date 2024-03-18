using UnityEngine;

class FizzBuzz : MonoBehaviour
{
    // Bemenet
    [SerializeField, Min(1)] int number = 1;

    void Start()
    {
        for (int i = 1; i <= number; i++)
        {
            // El�sz�r tesztelem az oszthat�s�got
            bool fizz = i % 3 == 0;
            bool buzz = i % 5 == 0;

            // T�bb�g� el�gaz�st haszn�lok
            // Fontos, hogy a FizzBuzz-zal kezdj�k (Gondold �t, mi�rt!)
            if (fizz && buzz)
                Debug.Log("FizzBuzz");
            else if (fizz)
                Debug.Log("Fizz");
            else if (buzz)
                Debug.Log("Buzz");
            else
                Debug.Log(i);
        }
    }
}