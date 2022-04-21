using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacktrig : MonoBehaviour
{
    public Animator anim;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            anim.SetTrigger("Attack");
        }

    }
}
