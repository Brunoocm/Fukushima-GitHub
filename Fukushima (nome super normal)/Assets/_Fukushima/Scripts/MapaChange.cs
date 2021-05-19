using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapaChange : MonoBehaviour
{
    [SerializeField] GameObject quarto;
    [SerializeField] GameObject escritorio;
    [SerializeField] GameObject Delegado;

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
        Delegado.SetActive(false);




    }
    public void TPlocal2()
    {
        quarto.SetActive(false);
        Delegado.SetActive(false);
        escritorio.SetActive(true);
        
        


    }   
    public void TPlocal3()
    {
        quarto.SetActive(false);
        Delegado.SetActive(true);
        escritorio.SetActive(false);
        
        


    }
}
