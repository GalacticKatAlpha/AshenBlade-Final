using System.Collections;
using UnityEngine;

public class Damage : MonoBehaviour
{
    int damage = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider dmg)
    {
        dmg.gameObject.GetComponent<DummyHealth>().TakeDamage(damage);
    }
}
