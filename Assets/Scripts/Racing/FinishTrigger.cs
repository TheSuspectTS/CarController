using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishTrigger : MonoBehaviour
{
    public GameObject winPanel;
    public bool finished;

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Player"){
            finished = true;
            winPanel.SetActive(true);
            FindObjectOfType<GameManager_Racing>().money += Random.Range(200, 300);
        }

        
    }
}
