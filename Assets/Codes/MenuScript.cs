using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    //Loads the game
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
    //Quits the game
    public void QuitGame()
    {
        Application.Quit();
        print("QUIT!");
    }
    //Loads Settings
}
