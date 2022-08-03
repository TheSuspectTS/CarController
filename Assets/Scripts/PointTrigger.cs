using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointTrigger : MonoBehaviour
{
    public GameObject nextPoint;

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Player"){
            gameObject.SetActive(false);
            nextPoint.SetActive(true);
            FindObjectOfType<GameManager_Racing>().pointsReady++;
        }
    }
}
