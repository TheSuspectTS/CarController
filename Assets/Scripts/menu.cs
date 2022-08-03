using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class menu : MonoBehaviour
{


    public void Playgame()
    {
        SceneManager.LoadScene("Demo");
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
        SceneManager.LoadScene("Menu");
    }

    public void Chustom()
    {
        SceneManager.LoadScene("Chustom");
;    }

    public void Choise()
    {
        SceneManager.LoadScene("host");
    }

    public void rases()
    {
        SceneManager.LoadScene("reses");
    }


}
