using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject scoreText;
    public static int TheScore;
 

    void Update()
    {
       scoreText.GetComponent<Text>().text = "Score:" + TheScore;
    }
}
