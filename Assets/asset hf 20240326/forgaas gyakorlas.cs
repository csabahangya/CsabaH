using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToClosest : MonoBehaviour
{
    [SerializeField] Transform target1, target2;  // Célpontok
    [SerializeField] float angularSpeed; // Szögsebesség

    void Update()
    {
        // Számítjuk ki az objektum és a cél1, valamint az objektum és a cél2 közötti távolságot
        float distance1 = Vector3.Distance(transform.position, target1.position);
        float distance2 = Vector3.Distance(transform.position, target2.position);

        // Kiválasztjuk a közelebbi célt az objektumhoz
        Vector3 targetPosition = distance1 < distance2 ? target1.position : target2.position;

        // Kiszámítjuk a cél irányát az objektumhoz képest
        Vector3 targetDirection = (targetPosition - transform.position).normalized;

        // Számítjuk ki a célt irányítására használt elfordulási irányítást
        Quaternion targetRotation = Quaternion.LookRotation(Vector3.forward, targetDirection);

        // Elforgatjuk az objektumot a cél felé az elfordulási sebesség és az idõintervallum alapján
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, angularSpeed * Time.deltaTime);
    }
}