using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameMenu : MonoBehaviour
{
    public KeyCode menuButton = KeyCode.Escape; 

    public GameObject menuPanel;
    public bool menuOpened;

    void Start()
    {
        
    }

    void Update()
    {
        MenuOpening();
    }

    public void Resume(){
        menuOpened = false;
    }

    private void MenuOpening(){
        if(Input.GetKeyDown(menuButton) && menuOpened == false){
            menuOpened = true;
        }else if(Input.GetKeyDown(menuButton) && menuOpened == true){
            menuOpened = false;
        }

        if(menuOpened == true){
            menuPanel.SetActive(true);
        }else{
            menuPanel.SetActive(false);
        }
    }

    public void BackToMenu(){
        SceneManager.LoadScene("MainMenu");
    }

    public void Exit(){
        Debug.Log("Exit!");
        Application.Quit();
    }
}
