using UnityEngine;

public class HF3 : MonoBehaviour
{
    [SerializeField] float arany, hp;
    [SerializeField] bool Bunk�kBuzog�nya;
    [SerializeField] bool Tr�kk�sT�r;
    [SerializeField] bool V�mpirfog;

    // Update is called once per frame
    void OnValidate()
    {
        Bunk�kBuzog�nya = arany >= 10f || hp > 50f;
        Tr�kk�sT�r = arany >= 4f || hp > 20f;
        V�mpirfog = arany >= 13f || hp > 65f;

    }
}
