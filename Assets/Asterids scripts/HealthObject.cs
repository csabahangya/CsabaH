using Unity.VisualScripting;
using UnityEngine;

public class HealthObject : MonoBehaviour
{
    [SerializeField] int startHp;

    public int currentHp;

    // Start is called before the first frame update
    void Start()
    {
        currentHp = startHp;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHp <= 0)
            Destroy(gameObject);
    }
}
