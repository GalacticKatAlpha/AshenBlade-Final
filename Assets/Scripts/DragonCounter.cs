using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DragonCounter : MonoBehaviour
{
    GameObject[] dragons;
    public Text dragonCountText;

    void Update()
    {
        dragons = GameObject.FindGameObjectsWithTag("Dragon");

        dragonCountText.text = "Dragons : " + dragons.Length.ToString();
    }
}
