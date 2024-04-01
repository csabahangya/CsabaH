using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lepkedes2 : MonoBehaviour
{
    [SerializeField] float speed;
    Vector3 target;

    // Start is called before the first frame update
    void Start()
    {
        target = transform.position;
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            target += Vector3.right;
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            target += Vector3.left;
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
            target += Vector3.up;
        if (Input.GetKeyDown(KeyCode.DownArrow))
            target += Vector3.down;

        Vector3 SelfPos = transform.position;

        transform.position = Vector3.MoveTowards(SelfPos, target, speed * Time.deltaTime );
    }
}
