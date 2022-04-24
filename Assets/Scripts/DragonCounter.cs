using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DragonCounter : MonoBehaviour
{
    GameObject[] dragons;
    public Text dragonCountText;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dragons = GameObject.FindGameObjectsWithTag("Dragon");

        dragonCountText.text = "Dragons : " + dragons.Length.ToString();
    }
}
