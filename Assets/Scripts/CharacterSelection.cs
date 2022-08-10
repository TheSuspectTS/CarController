using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CharacterSelection : MonoBehaviour
{
    public bool racesShop;
    public GameObject buyBtn;

    public GameObject[] characters;
    public int selectedCharacter = 0;

    public int car2Byed = 0;
    public int car3Byed = 0;

    public int car2Cost;
    public int car3Cost;

    public Text costText;
    public Text moneyText;

    public int money;

    private void Start()
    {
        money = PlayerPrefs.GetInt("money");
        car2Byed = PlayerPrefs.GetInt("car2Byed");
        car3Byed = PlayerPrefs.GetInt("car3Byed");
    }

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

    public void BuyBtn()
    {
        if(selectedCharacter == 1 && money >= car2Cost)
        {
            money -= car2Cost;
            PlayerPrefs.SetInt("money", money);
            PlayerPrefs.SetInt("car2Byed", 1);
        }
        else if (selectedCharacter == 2 && money >= car3Cost)
        {
            money -= car3Cost;
            PlayerPrefs.SetInt("money", money);
            PlayerPrefs.SetInt("car3Byed", 1);
        }

    }

    private void Update()
    {
        moneyText.text = "Денег: " + money.ToString();

        if (selectedCharacter == 1 && PlayerPrefs.GetInt("car2Byed") == 0)
        {
            buyBtn.SetActive(true);
            costText.text = "Цена: " + car2Cost;
        }
        else if(selectedCharacter == 1 && PlayerPrefs.GetInt("car2Byed") == 1)
        {
            buyBtn.SetActive(false);
            costText.text = "";
        }

        if (selectedCharacter == 2 && PlayerPrefs.GetInt("car3Byed") == 0)
        {
            buyBtn.SetActive(true);
            costText.text = "Цена: " + car3Cost;
        }
        else if(selectedCharacter == 2 && PlayerPrefs.GetInt("car3Byed") == 1)
        {
            buyBtn.SetActive(false);
            costText.text = "";
        }

        if (selectedCharacter == 0)
        {
            buyBtn.SetActive(false);
            costText.text = "";
        }
    }
}
