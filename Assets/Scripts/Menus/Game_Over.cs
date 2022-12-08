using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Over : MonoBehaviour
{
    public Canvas canvas;


    public void Playgame()
    {
  
        SceneManager.LoadScene(0);


       

    }
    public void QuitGame()
    {
        Application.Quit();
    }

}
