using UnityEngine;

public class VectorPractice : MonoBehaviour
{

    void Start()
    {
        Vector2 myVector = new (2, 3);

        float x = myVector.x;
        float y = myVector.y;

        Vector2 myOtherVector = new Vector2(4, 9);

        Vector2 summa = myVector + myOtherVector;
        Vector2 diff = myVector - myOtherVector;
        Vector2 mult = 5 * diff;
        Vector2 div = summa / 2;

        float vectorlenght = summa.magnitude;

        Vector2 normalized = summa.normalized;

    }
}
