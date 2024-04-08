using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pozRajzolo : MonoBehaviour
{
    [SerializeField] float hossz;

    // Start is called before the first frame update
    void OnDrawGizmos()
    {
        Vector3 a = transform.position;

        Gizmos.color = Color.red;
        Vector3 x = hossz * transform.right;
        Gizmos.DrawLine(a - x, a + x);
        Gizmos.DrawSphere(a + x, hossz / 5);

        Gizmos.color = Color.green;
        Vector3 y = hossz * transform.up;
        Gizmos.DrawLine (a - y, a + y);
        Gizmos.DrawSphere (a + y, hossz / 5);

        Gizmos.color = Color.blue;
        Vector3 z = hossz * transform.forward;
        Gizmos.DrawLine(a - z, a + z);
        Gizmos.DrawSphere(a + z, hossz / 5);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
