using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooter : MonoBehaviour
{
    [SerializeField] GameObject projectilePrototype;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject newProjectile = Instantiate(projectilePrototype);

            newProjectile.transform.position = transform.position;
            newProjectile.transform.rotation = transform.rotation;
        }
    }
}
