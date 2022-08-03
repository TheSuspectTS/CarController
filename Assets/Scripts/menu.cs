using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class menu : MonoBehaviour
{


    public void PlayGame()
    {
        SceneManager.LoadScene("FreeWorld");
        Cursor.visible = false;
    }
    public void Playmultipalyer()
    {
        SceneManager.LoadScene("Loading");
        Cursor.visible = true;
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void CustomMenu()
    {
        SceneManager.LoadScene("CustomMenu");
    }

    public void ModeSelection()
    {
        SceneManager.LoadScene("ModeSelection");
    }

    public void Races()
    {
        SceneManager.LoadScene("Races");
    }


}
