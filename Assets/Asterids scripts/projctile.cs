using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class projctile : MonoBehaviour
{
    [SerializeField] float speed = 5;
    [SerializeField] float lifetime = 2;
    [SerializeField] int damage = 10;


    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifetime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * speed * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        HealthObject healthObject = other.GetComponent<HealthObject>();
        if(healthObject != null)
        {
            healthObject.currentHp -= damage;
            Destroy(gameObject);
        }
    }

}
