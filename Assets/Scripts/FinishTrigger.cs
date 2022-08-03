using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishTrigger : MonoBehaviour
{
    public GameObject winPanel;

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Player"){
            winPanel.SetActive(true);
        }
    }
}
