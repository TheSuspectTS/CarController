using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMenu : MonoBehaviour
{
    public KeyCode mapButton = KeyCode.M;
    public bool mapOpened;
    public GameObject mapGO;

    void Start()
    {
        mapGO.SetActive(false);
    }

    void Update()
    {
        if(Input.GetKeyDown(mapButton)){
            if(mapOpened == false){
                mapOpened = true;
                mapGO.SetActive(true);
            }else if(mapOpened == true){
                mapOpened = false;
                mapGO.SetActive(false);
            }
        }
    }
}
