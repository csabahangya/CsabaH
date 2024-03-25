using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class primszam : MonoBehaviour
{
    [SerializeField] int n;

    // Start is called before the first frame update
    void Start()
    {
        WriteFirstPrimes(n);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void WriteFirstPrimes(int n)
    {
        int numbersFound = 0; // Hány elemet találtunk eddig
        for (int i = 1; numbersFound < n; i++)  // Végignézzük az összes számot
        {
            if (IsPrime(i))          // He igaz a feltétel
            {
                // Kiírjuk a számot a feladat szerint.     (Csak az egyik kell)
                Console.WriteLine(i);  // Parancsori kiíratás
                Debug.Log(i);          // Unity kiíratás

                numbersFound++;        // Ha ezt kihagyjuk, végtelen ciklust kapunk
            }
        }
    }

    // Segédfüggvény
    bool IsPrime(int n)        // Prímszám-e
    {
        if (n < 2)               // 2 alatt nincs prím
            return false;

        // Letesztelem az összes számot, 2 és gyök n közt, hogy osztó-e.
        float sqrt = (float)Math.Sqrt(n);    // n négyzetgyöke  (Unity-ben Mathf)

        // A négyzetgyök felett fölösleges osztót keresni
        for (int i = 2; i <= sqrt; i++)
        {
            if (n % i == 0)     // Ha találtunk osztót
                return false;   // Akkor nem prím
        }

        return true;  // Ha nem találtunk osztót, akkor prím
    }


}
