using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListPractice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<string> myList = new();
        myList.Add("AA");
        myList.Add("BB");
        myList.Add("CC"); // sorrend: "AA", "BB", "CC"

        myList.Insert(0, "XX"); // sorrend: "XX", "AA", "BB", "CC"
        myList.Insert(2, "YY"); // sorrend: "XX", "AA", "YY", "BB", "CC"

        myList.Remove("XX"); // sorrend: "AA", "YY", "BB", "CC"
        bool foundZZ = myList.Remove("ZZ"); // sorrend: "AA", "YY", "BB", "CC" //false

        myList.RemoveAt(2); // sorrend: "AA", "YY", "CC"

        int index = myList.IndexOf("YY"); //1
        bool contansZZ = myList.Contains("ZZ"); //false

        myList.Sort(); // sorrend: "AA", "CC", "YY" //ABC sorrend
        myList.Reverse(); // sorrend: "YY", "CC", "AA" 
    }
    //_____________________________________________

    float Mean(List<float> numbers)
    {
        float summa = 0;
        foreach (float current in numbers)
        {
            summa += current;
        }
        return summa / numbers.Count;
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
