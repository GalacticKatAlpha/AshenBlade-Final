using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleAttacks : MonoBehaviour
{
    private Animator anim;

    private void Start()
    {

    }

    IEnumerator Attack()
    {
        anim = GetComponent<Animator>();

        while (true)
        {
            yield return new WaitForSeconds(5);
            anim.SetTrigger("Attack");
            GetComponent<BoxCollider>().enabled = true;
            yield return new WaitForSeconds(2);
            GetComponent<BoxCollider>().enabled = false;
        }
    }
}
