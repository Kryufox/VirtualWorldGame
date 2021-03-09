using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loadlvl : MonoBehaviour
{
    public int numberScene;
    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene(numberScene);
        }
    }
}
