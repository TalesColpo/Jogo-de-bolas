using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Over : MonoBehaviour
{

    public GameObject Destroy;

    public void Playgame()
    {
        SceneManager.LoadScene(0);
        Destroy(Destroy);

          }
    public void QuitGame()
    {
        Application.Quit();
    }
   
}
