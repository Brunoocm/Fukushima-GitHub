using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapaChange : MonoBehaviour
{
    [SerializeField] GameObject quarto;
    [SerializeField] GameObject escritorio;

    void Start()
    {

    }

    void Update()
    {
    }

    public void TPlocal()
    {
        quarto.SetActive(true);
        escritorio.SetActive(false);




    }
    public void TPlocal2()
    {
        quarto.SetActive(false);
        escritorio.SetActive(true);
        
        


    }
}
