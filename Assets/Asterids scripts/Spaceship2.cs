using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Spaceship2 : MonoBehaviour
{
    [SerializeField] float maxSpeed = 5;
    [SerializeField] float acceleration = 5;
    [SerializeField] float angularSpeed = 180;
    [SerializeField] float drag = 0.5f;

    Vector3 velocity;

    void Update()
    {
        // Input
        float x = Input.GetAxisRaw("Horizontal");
        // Mozgás
        Vector3 step = velocity * Time.deltaTime;
        transform.position += step;
        // Forgatás
        transform.Rotate(0, 0, angularSpeed * -x * Time.deltaTime);
    }
    void FixedUpdate()
    {
        // Input
        float y = Input.GetAxisRaw("Vertical");
        // Gyorsitás
        velocity += transform.up * acceleration * y * Time.fixedDeltaTime;
        // Lassitás
        Vector3 dragVector = -velocity * drag;
        velocity += dragVector * Time.fixedDeltaTime;
        // Max sebesség
        velocity = Vector3.ClampMagnitude(velocity, maxSpeed);
    }
}
