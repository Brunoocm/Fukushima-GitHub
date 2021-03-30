using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPistas : MonoBehaviour
{
    [SerializeField] private  GameObject[] allPsistas;

    [SerializeField] private Transform objects;
    private int pistasInt;


    private void Update()
    {
        allPsistas = new GameObject[objects.transform.childCount];
        for (int i = 0; i < objects.transform.childCount; i++)
        {
            allPsistas[i] = objects.transform.GetChild(i).gameObject;
        }
    }

}

