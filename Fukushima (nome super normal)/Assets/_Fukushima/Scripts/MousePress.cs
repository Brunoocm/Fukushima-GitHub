using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePress : MonoBehaviour
{
    public bool ponto;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if(ponto)
        {
            ponto = false;
        }
        else
        {
            ponto = true;

        }
    }
}
