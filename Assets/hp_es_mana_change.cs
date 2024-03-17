using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class hp_es_mana_change : MonoBehaviour
{
    [SerializeField] int hp;
    [SerializeField] int mana;

    void Update()
    {
        bool presskey1 = Input.GetKeyDown(KeyCode.A);
        if (presskey1)
        {
            if (hp > 0)
            {
                Debug.Log("mana + 1");
                hp--;
                mana++;
            }
            else
                Debug.Log("not enough hp");
        }

        bool presskey2 = Input.GetKeyDown(KeyCode.Q);
        if (presskey2)
        {
            if (mana > 0)
            {
                Debug.Log("hp + 1");
                mana--;
                hp++;
            }
            else
                Debug.Log("not enough mana");
        }
    }
}