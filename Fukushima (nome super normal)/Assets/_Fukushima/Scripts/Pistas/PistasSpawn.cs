using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistasSpawn : MonoBehaviour
{
    public GameObject[] pistasPivotSpawner;
    void Start()
    {

        pistasPivotSpawner = GameObject.FindGameObjectsWithTag("PistasPivotSpawn");

       
    }

    void Update()
    {
        
    }

    public void SpawnPista()
    {
     

    }
}
