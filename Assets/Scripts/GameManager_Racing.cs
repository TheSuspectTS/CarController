using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManager_Racing : MonoBehaviour
{
    public Text pointsText;
    public Text timerText;
    public int pointsReady;
    int maxPoints;

    public GameObject[] points;
    public float timer;

    void Start()
    {
        maxPoints = points.Length;
    }

    void Update()
    {
        if(FindObjectOfType<FinishTrigger>().winPanel.activeInHierarchy == false){
            timer += Time.deltaTime;
        }

        if(FindObjectOfType<FinishTrigger>().winPanel.activeInHierarchy == true){
            timerText.text = ("You have finished in: " + Mathf.Round(timer) + " sec");
        }

        pointsText.text = (pointsReady + "/" + maxPoints);
    }
}
