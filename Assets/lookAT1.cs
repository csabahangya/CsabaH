using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookAT1 : MonoBehaviour
{
    // van egy kocka �s egy g�mb game object. A kock�ra irjuk a scriptet �s a g�mbre akarunk n�zni vele
    [SerializeField] Transform toLookat; // megadunk egy m�sik game objectet, amihez majd viszonyitunk
    [SerializeField] float speed; // sebess�g v�ltoz�
    [SerializeField] float angularSpeed = 360; // sz�gsebess�g v�ltoz�
    void Update()
    {
        Vector3 self = transform.position; // sajat pozicio
        Vector3 other = toLookat.position; // masik poyici "toLookat" pozici�ja
        Vector3 direction = other - self; // other fel� mutat� vektor kell
        direction.Normalize(); // normaliz�ljuka direction vektort

        if (direction != Vector3.zero) // Zero pontn�l ne t�rt�njen m�velet
        {
            Quaternion targetDirection = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.RotateTowards
                (transform.rotation, targetDirection, angularSpeed * Time.deltaTime); // elforgat�s bizonyos sz�gsebess�ggel
        }

        transform.position = Vector3.MoveTowards(self, other, speed * Time.deltaTime); // mozg�s a c�l fel�
  
    }
}
