using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour
{
    public bool racesShop;

    public GameObject[] characters;
    public int selectedCharacter = 0;

    public  void NextCharacter(){
        characters[selectedCharacter].SetActive(false);
        selectedCharacter = (selectedCharacter + 1) % characters.Length;
        characters[selectedCharacter].SetActive(true);
    }

    public void PreviousCharacter(){
        characters[selectedCharacter].SetActive(false);
        selectedCharacter--;
        if(selectedCharacter < 0){
            selectedCharacter += characters.Length;
        }
        characters[selectedCharacter].SetActive(true);
    }

    public void StartGame(){
        PlayerPrefs.SetInt("selectedCharacter", selectedCharacter);
        if(racesShop)
            SceneManager.LoadScene("Races");
        else
            SceneManager.LoadScene("FreeWorld");
    }
}
