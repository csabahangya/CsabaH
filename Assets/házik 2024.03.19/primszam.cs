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
        int numbersFound = 0; // H�ny elemet tal�ltunk eddig
        for (int i = 1; numbersFound < n; i++)  // V�gign�zz�k az �sszes sz�mot
        {
            if (IsPrime(i))          // He igaz a felt�tel
            {
                // Ki�rjuk a sz�mot a feladat szerint.     (Csak az egyik kell)
                Console.WriteLine(i);  // Parancsori ki�rat�s
                Debug.Log(i);          // Unity ki�rat�s

                numbersFound++;        // Ha ezt kihagyjuk, v�gtelen ciklust kapunk
            }
        }
    }

    // Seg�df�ggv�ny
    bool IsPrime(int n)        // Pr�msz�m-e
    {
        if (n < 2)               // 2 alatt nincs pr�m
            return false;

        // Letesztelem az �sszes sz�mot, 2 �s gy�k n k�zt, hogy oszt�-e.
        float sqrt = (float)Math.Sqrt(n);    // n n�gyzetgy�ke  (Unity-ben Mathf)

        // A n�gyzetgy�k felett f�l�sleges oszt�t keresni
        for (int i = 2; i <= sqrt; i++)
        {
            if (n % i == 0)     // Ha tal�ltunk oszt�t
                return false;   // Akkor nem pr�m
        }

        return true;  // Ha nem tal�ltunk oszt�t, akkor pr�m
    }


}
