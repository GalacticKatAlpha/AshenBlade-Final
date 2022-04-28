using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonTag : DragonHealth
{

    void Update()
    {
        if (currentHealth <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
