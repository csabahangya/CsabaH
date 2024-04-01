using UnityEngine;

public class Fleeing : MonoBehaviour
{
    [SerializeField] Transform chaser;   // Az az objektum, amely �ld�zi ezt az objektumot 
    [SerializeField] float minDistance;  // A minim�lis t�vols�g, amelyen bel�l a menek�l�si viselked�s elkezd�dik
    [SerializeField] float acceleration; // A menek�l�s gyorsul�s�nak (�s lassul�s�nak) m�rt�ke
    [SerializeField] float maxSpeed;     // Az objektum �ltal el�rhet� maxim�lis sebess�g

    Vector3 velocity; // Az objektum jelenlegi sebess�gvektora

    void Update()
    {
        // Sz�m�tjuk ki az objektum �s az �ld�z� k�z�tti t�vols�gvektort �s hossz�t
        Vector3 distanceVector = (transform.position - chaser.position);
        float distance = distanceVector.magnitude;

        bool isFleeing = distance < minDistance; // �ppen menek�l�nk-e?

        if (isFleeing) // Ha menek�l�nk, akkor...
        {
            // A t�vols�g alapj�n sz�m�tjuk ki az �ld�z� ir�ny�t�s�ra haszn�lni k�v�nt ir�nyvektort
            Vector3 direction = distanceVector / distance; // Normaliz�l�s
                                                           // ...n�velj�k a sebess�get az ir�ny�t�shoz
            velocity += acceleration * Time.deltaTime * direction;
            //�s v�g�l korl�tozzuk a sebess�get, ha t�l nagy lenne
            velocity = Vector3.ClampMagnitude(velocity, maxSpeed);
        }
        else // Ha nem menek�l�nk, akkor...
        {
            // ...lass�tsuk le a sebess�get a nulla fel�
            velocity = Vector3.MoveTowards(velocity, Vector3.zero, acceleration * Time.deltaTime);
        }

        // L�p�nk egyet: Friss�tj�k az objektum poz�ci�j�t a sebess�gvektor �s a id�intervallum szorzat�val
        transform.position += velocity * Time.deltaTime;
    }
}
