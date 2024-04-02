using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lepkedes : MonoBehaviour
{
    [SerializeField] KeyCode rightkey = KeyCode.RightArrow;
    [SerializeField] KeyCode leftkey = KeyCode.LeftArrow;
    [SerializeField] KeyCode upkey = KeyCode.UpArrow;
    [SerializeField] KeyCode downkey = KeyCode.DownArrow;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(rightkey))
            transform.position += Vector3.right;
        if (Input.GetKeyDown(leftkey))
            transform.position += Vector3.left;
        if (Input.GetKeyDown(upkey))
            transform.position += Vector3.up;
        if (Input.GetKeyDown(downkey))
            transform.position += Vector3.down;


    }
}
