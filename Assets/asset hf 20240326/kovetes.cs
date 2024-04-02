using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kovetes : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float speed;
    [SerializeField] float minDistance = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 TargetPostion = target.position;
        Vector3 SelfPostion = transform.position;

        Vector3 Movement = TargetPostion - SelfPostion;
        float distance = Movement.magnitude;

        if (distance <= minDistance)
            return;

        Movement.Normalize();

        transform.position += Movement * speed * Time.deltaTime;

    }
}

/*__________________________
using UnityEngine;

public class DistancedFollower : MonoBehaviour
{
    [SerializeField] GameObject target;
    [SerializeField] float speed;
    [SerializeField] float maxDistance;

    void Updat()
    {
        Vector3 distanceV = target.transform.position - transform.position;
        float distance = distanceV.magnitude;

        if (distance > maxDistance)
        {
            Vector3 direction = distanceV / distance;
            transform.position += direction * speed * Time.deltaTime;
        }
    }
}

________________________*/