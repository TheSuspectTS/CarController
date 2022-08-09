using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class menu : MonoBehaviour
{
    public void ModeSelection()
    {
        SceneManager.LoadScene("ModeSelection");
    }


    public void RacesShop()
    {
        SceneManager.LoadScene("RacesShop");
    }
    public void FreeWorldShop()
    {
        SceneManager.LoadScene("FreeWorldShop");
    }


    public void ExitGame()
    {
        Application.Quit();
    }
    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
