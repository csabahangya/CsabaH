using UnityEngine;

class FizzBuzz : MonoBehaviour
{
    // Bemenet
    [SerializeField, Min(1)] int number = 1;

    void Start()
    {
        for (int i = 1; i <= number; i++)
        {
            // Elõször tesztelem az oszthatóságot
            bool fizz = i % 3 == 0;
            bool buzz = i % 5 == 0;

            // Többágú elágazást használok
            // Fontos, hogy a FizzBuzz-zal kezdjük (Gondold át, miért!)
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