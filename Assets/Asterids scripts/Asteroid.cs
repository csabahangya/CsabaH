using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    [SerializeField] float maxSpeed;
    [SerializeField] float maxAngularSpeed;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        rb.angularVelocity = Random.Range(-maxAngularSpeed, maxAngularSpeed);

        Vector2 v = Random.insideUnitCircle * maxSpeed;
        rb.velocity = v;
    }
    void OnDestroy()
    {
        FindObjectOfType<AsteroidSpawner>().RemoveAsteroid(this);
        
    }
}
