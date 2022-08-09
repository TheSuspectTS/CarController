using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointTrigger : MonoBehaviour
{
    public GameObject nextPoint;
    public GameObject nextPointModel;
    public bool nextFinish = false;

    private void OnTriggerEnter(Collider other) {
        if(nextFinish == true && other.tag == "Player"){
            gameObject.SetActive(false);
            nextPoint.SetActive(true);
            nextPointModel.SetActive(true);
            nextPoint.GetComponent<Collider>().enabled = true;
            FindObjectOfType<GameManager_Racing>().pointsReady++;
        }
        else if(other.tag == "Player"){
            gameObject.SetActive(false);
            nextPoint.SetActive(true);
            FindObjectOfType<GameManager_Racing>().pointsReady++;
        }
    }
}
