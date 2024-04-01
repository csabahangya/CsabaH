using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class kovetes2 : MonoBehaviour
{
    [SerializeField] Transform target1, target2;
    [SerializeField] float speed = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 SelfPosition = transform.position;

        float distance1 = Vector3.Distance(target1.position, SelfPosition);
        float distance2 = Vector3.Distance(target2.position, SelfPosition);

        Transform target;
        if (distance1 < distance2)
            target = target1;
        else 
            target = target2; ;

        Vector3 TargetpPostion = target.position;

        Vector3 movement = TargetpPostion - SelfPosition;
        movement.Normalize();

        transform.position += movement * (Time.deltaTime * speed);


    }
}
