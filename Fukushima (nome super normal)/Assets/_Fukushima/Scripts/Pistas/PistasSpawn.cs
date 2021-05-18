using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PistasSpawn : MonoBehaviour
{
    public GameObject[] pistasPivotSpawner;

    Animator pistaAnimator; 
    Animator LocalAnimator; 
    void Start()
    {

        pistasPivotSpawner = GameObject.FindGameObjectsWithTag("PistasPivotSpawn");
        pistaAnimator = GameObject.Find("LampadaPista").GetComponent<Animator>();
        LocalAnimator = GameObject.Find("LampadaItem").GetComponent<Animator>();



    }

    void Update()
    {
        
    }

    public void SpawnPista()
    {
        pistaAnimator.SetTrigger("lampada");
    } 
    public void LocalAtualizado()
    {
        LocalAnimator.SetTrigger("lampada");
    }
}
