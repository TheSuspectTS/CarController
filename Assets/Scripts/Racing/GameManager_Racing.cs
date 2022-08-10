using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManager_Racing : MonoBehaviour
{
    public Text pointsText;
    public Text moneyText;
    public Text timerText;
    public int pointsReady;
    int maxPoints;

    public FinishTrigger ft;
    public GameObject[] points;
    public float timer;
    public int money;

    void Start()
    {
        money = PlayerPrefs.GetInt("money");

        maxPoints = points.Length;
    }

    void Update()
    {
        moneyText.text = "Δενόγθ: " + money.ToString();

        if (FindObjectOfType<FinishTrigger>().winPanel.activeInHierarchy == false){
            timer += Time.deltaTime;
        }

        if(FindObjectOfType<FinishTrigger>().winPanel.activeInHierarchy == true){
            timerText.text = ("You have finished in: " + Mathf.Round(timer) + " sec");
        }

        pointsText.text = (pointsReady + "/" + maxPoints);

        if(ft.finished)
            PlayerPrefs.SetInt("money", money);
    }
}
