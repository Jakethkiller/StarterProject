using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer2 : MonoBehaviour
{
 
    public float timeLeft = 3.0f;
    public Text startText; // used for showing countdown from 3, 2, 1 
 
 
    void Update()
    {
        timeLeft -= Time.deltaTime;
        startText.text = (timeLeft).ToString("0");
        if (timeLeft <= 0)
        {
             GameOver();
             timeLeft = 0;
             
        }
    }
 
     public void GameOver()
        {
         if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
        }
}
