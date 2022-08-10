using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointTrigger : MonoBehaviour
{
    public GameObject nextPoint;
    public GameObject nextPointModel;
    public bool nextFinish = false;
    public GameManager_Racing gmr;

    private void OnTriggerEnter(Collider other) {
        if(nextFinish == true && other.tag == "Player"){
            gameObject.SetActive(false);
            nextPoint.SetActive(true);
            nextPointModel.SetActive(true);
            nextPoint.GetComponent<Collider>().enabled = true;
            gmr.money += Random.Range(100, 200);
            gmr.pointsReady++;
        }
        else if(other.tag == "Player"){
            gameObject.SetActive(false);
            nextPoint.SetActive(true);
            gmr.money += Random.Range(100, 200);
            gmr.pointsReady++;
        }
    }
}
