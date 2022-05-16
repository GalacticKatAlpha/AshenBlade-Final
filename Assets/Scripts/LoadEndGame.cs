using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadEndGame : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag("EndGame"))
        {
            SceneManager.LoadScene("End Game Screen");
        }
    }
}
