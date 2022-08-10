using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnSpawn : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
