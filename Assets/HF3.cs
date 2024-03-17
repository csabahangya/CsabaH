using UnityEngine;

public class HF3 : MonoBehaviour
{
    [SerializeField] float arany, hp;
    [SerializeField] bool BunkókBuzogánya;
    [SerializeField] bool TrükkösTõr;
    [SerializeField] bool Vámpirfog;

    // Update is called once per frame
    void OnValidate()
    {
        BunkókBuzogánya = arany >= 10f || hp > 50f;
        TrükkösTõr = arany >= 4f || hp > 20f;
        Vámpirfog = arany >= 13f || hp > 65f;

    }
}
