using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class CD : MonoBehaviour
{
    bool loadingStarted = false;
    float secondsLeft = 0;

    void Start()
    {
        StartCoroutine(DelayLoadLevel(10));
        
    }

    IEnumerator DelayLoadLevel(float seconds)
    {
        secondsLeft = seconds;
        loadingStarted = true;
        do
        {
            yield return new WaitForSeconds(1);
        } while (--secondsLeft > 0);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void OnGUI()
    {
        if (loadingStarted)
            GUI.Label(new Rect(0, 0, 100, 20), secondsLeft.ToString());
    }
    public static void EndScreen()
    {

    }
}