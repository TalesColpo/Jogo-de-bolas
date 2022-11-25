using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public static int scoreAmount;
    private Text scoreText;

    //this game object will not get destroyed between scene loading

    void Start()
    {
        scoreText = GetComponent<Text>();
        scoreAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score:" + scoreAmount;

        if (scoreAmount > PlayerPrefs.GetInt("highscore"))
        {
            PlayerPrefs.SetInt("highscore", scoreAmount);
        }
        
    }
   
    
      

    
}
