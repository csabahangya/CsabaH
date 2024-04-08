using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookAT1 : MonoBehaviour
{
    // van egy kocka és egy gömb game object. A kockára irjuk a scriptet és a gömbre akarunk nézni vele
    [SerializeField] Transform toLookat; // megadunk egy másik game objectet, amihez majd viszonyitunk
    [SerializeField] float speed; // sebesség változó
    [SerializeField] float angularSpeed = 360; // szögsebesség változó
    void Update()
    {
        Vector3 self = transform.position; // sajat pozicio
        Vector3 other = toLookat.position; // masik poyici "toLookat" poziciója
        Vector3 direction = other - self; // other felé mutató vektor kell
        direction.Normalize(); // normalizáljuka direction vektort

        if (direction != Vector3.zero) // Zero pontnál ne történjen mûvelet
        {
            Quaternion targetDirection = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.RotateTowards
                (transform.rotation, targetDirection, angularSpeed * Time.deltaTime); // elforgatás bizonyos szögsebességgel
        }

        transform.position = Vector3.MoveTowards(self, other, speed * Time.deltaTime); // mozgás a cél felé
  
    }
}
