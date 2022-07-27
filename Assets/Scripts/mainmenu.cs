using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void playgame()
    {
        SceneManager.LoadScene(1);
    }
    public void menu()
    {
        SceneManager.LoadScene(0);
    }
    //public void back()
    //{
    //    SceneManager.LoadScene()
    //}
    public void quitgame ()
    {
        Debug.Log("over");
        Application.Quit();
    }
}
