using UnityEngine;

public class menekules2 : MonoBehaviour
{
    [SerializeField] Transform chaser;
    [SerializeField] float maxRange;
    [SerializeField] float acceleration;
    [SerializeField] float maxSpeed;

    Vector3 velocity;

    void Update()
    {
        Vector3 selfPoint = transform.position;
        Vector3 chaserPoint = chaser.position;

        float distance = Vector3.Distance(selfPoint, chaserPoint);

        if (distance < maxRange)
        {
            // Menekülés : Gyorsulás
            Vector3 direction = (selfPoint - chaserPoint).normalized;
            velocity += direction * acceleration * Time.deltaTime;
            velocity = Vector3.ClampMagnitude(velocity, maxSpeed);  // Max sebesség
        }
        else
        {
            // Lassul
            velocity = Vector3.MoveTowards(velocity, Vector3.zero, acceleration * Time.deltaTime);
        }

        // Mozgunk
        transform.position += velocity * Time.deltaTime;


    }

    private void OnDrawGizmosSelected()
    {
        Color c = new Color(0.5f, 0.5f, 0.5f, 0.5f);
        Gizmos.color = c;
        Gizmos.DrawWireSphere(transform.position, maxRange);

    }

}