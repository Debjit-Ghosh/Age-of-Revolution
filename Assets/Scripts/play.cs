using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class play : MonoBehaviour
{
    // Start is called before the first frame update
    public void mainMenu()
    {
        SceneManager.LoadScene(0);
    }
      
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex   + 1);

    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("aaaa");
    }
}
