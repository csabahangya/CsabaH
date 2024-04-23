using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class legkozelebbiTransform : MonoBehaviour
{
    // Start is called before the first frame update

    Transform Closest(Transform[] obejcts)
    {
        float minDistance = float.MaxValue;
        Transform closest = null;
        Vector3 self = transform.position;

        for (int i = 0; i < obejcts.Length; i++)
        {
            float distance = (self - obejcts[i].position).magnitude;
            if (distance < minDistance)
            {
                minDistance = distance;
                closest = obejcts[i];
            }
        }

        return closest;
    }
}
