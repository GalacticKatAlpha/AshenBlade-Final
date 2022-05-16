using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonAttacks : MonoBehaviour
{
    private Animator anim;

    IEnumerator Attack()
    {
        anim = GetComponent<Animator>();

        while (true)
        {
            yield return new WaitForSeconds(5);

            GetComponent<Patroller>().enabled = false;
            GetComponent<BoxCollider>().enabled = true;

            anim.SetInteger("AttackIndex", Random.Range(0, 4));
            anim.SetTrigger("Attack");

            GetComponent<Patroller>().enabled = true;
            GetComponent<BoxCollider>().enabled = false;
        }
    }
}
