using UnityEngine;

public class ketpontkozott : MonoBehaviour
{
    [SerializeField] Transform a, b;
    [SerializeField, Range(0,1)] float rate;
    [SerializeField] float speed = 5;

    void Start()
    {
        
    }
    void Update()
    
    {
        Vector3 ap = a.position;
        Vector3 bp = b.position;

        //Vector3 distanceVector = ap - bp;
        //distanceVector /= 2;
        //transform.position = bp + distanceVector;

        //transform.position = (rate * ap + (1 - rate) * bp);

        transform.position = Vector3.Lerp(ap, bp, rate);
        transform.rotation = Quaternion.Lerp(a.rotation, b.rotation, rate);

        transform.position = Vector3.MoveTowards(transform.position, b.position, speed * Time.deltaTime);
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(a.position, b.position);
    }
}
