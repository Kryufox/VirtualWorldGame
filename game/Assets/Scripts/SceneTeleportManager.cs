using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTeleportManager : MonoBehaviour
{
    private static SceneTeleportManager instance;
   
    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            SceneManager.LoadScene("Scene1");
        }
       else if (Input.GetKeyDown("2"))
        {
            SceneManager.LoadScene("Scene2");
        }
    }
   }
