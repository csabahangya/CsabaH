using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEditor.UI;
using UnityEngine;

public class kovetoRaketa : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float anularSpeed;
    [SerializeField] Transform target;

    // Update is called once per frame
    void Update()
    {
     
        Vector3 direction = target.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(direction);

        float maxAngle = anularSpeed * Time.deltaTime;
        transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, maxAngle);

        transform.position += transform.forward * speed * Time.deltaTime;

    }

}
