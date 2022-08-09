using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectCharter : MonoBehaviour
{
    private int i;
    public GameObject[] AllCharacters;
    public GameObject ArrowToLeft;
    public GameObject ArrowToRight;
    private int currectCharacter;

    public GameObject ButtonSelected;
    public GameObject TextSlected;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("CurrentCharacter"))
        {
            i = PlayerPrefs.GetInt("CurrentCharacter");
            currectCharacter = PlayerPrefs.GetInt("CurrentCharacter");
        }
        else
        {
            PlayerPrefs.SetInt("CurrentCharacter", i);
        }
        AllCharacters[i].SetActive(true);

        

        if (i > 0)
        {
            ArrowToLeft.SetActive(true);
        }
        if (i == AllCharacters.Length)
        {
            ArrowToRight.SetActive(false);
        }
    }
    public void ArrowRight()
    {
        if (i < AllCharacters.Length)
        {
            if (i == 0)
            {
                ArrowToLeft.SetActive(true);
            }

            AllCharacters[i].SetActive(false);
            i++;
            AllCharacters[i].SetActive(true);
            if (currectCharacter == i)
            {
                ButtonSelected.SetActive(false);
                TextSlected.SetActive(true);
            }
            else
            {
                ButtonSelected.SetActive(true);
                TextSlected.SetActive(false);
            }

            if (i + 1 == AllCharacters.Length)
            {
                ArrowToRight.SetActive(false);
            }
        }
    }
    public void ArrowLeft()
    {
        if (i < AllCharacters.Length)
        {
            AllCharacters[i].SetActive(false);
            i--;
            AllCharacters[i].SetActive(true);
            ArrowToRight.SetActive(true);

            if (currectCharacter == i)
            {
                ButtonSelected.SetActive(false);
                TextSlected.SetActive(true);
            }
            else
            {
                ButtonSelected.SetActive(true);
                TextSlected.SetActive(false);
            }

            if (i == 0)
            {
                ArrowToLeft.SetActive(false);
            }
        }
    }

    public void SelectCharters()
    {
        PlayerPrefs.SetInt("CurrentCharacter", i);
        currectCharacter = i;
        ButtonSelected.SetActive(false);
        TextSlected.SetActive(true);
    }

}
