using UnityEngine;

public class repeatHF7 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= 10; i++)
            for (int j = 0; j <= 10; j++)
                Debug.Log($"{i} * {j} = {i*j}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


