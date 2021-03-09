using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject TheEnemy;
    public int AttackTrigger;
    public int Damage;

    // Update is called once per frame
    void Update()
    {
        if (AttackTrigger == 0)
        {
            TheEnemy.GetComponent<Animation>().Play("move_forward");
        }
        if (AttackTrigger ==1)
        { if (Damage == 0)
            {
                TheEnemy.GetComponent<Animation>().Play("attack_short_001");
                //StartCoroutine(TakingDamage());
                    } }
    }
}
