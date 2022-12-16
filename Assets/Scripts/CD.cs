using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class CD : MonoBehaviour
{
    bool loadingStarted = false;
    float secondsLeft = 0;
    public GameObject text ;

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
        DontDestroyOnLoad(text);
       
    }

    void OnGUI()
    {
        if (loadingStarted)
            GUI.Label(new Rect(0, 0, 0, 20), secondsLeft.ToString());
    }

}