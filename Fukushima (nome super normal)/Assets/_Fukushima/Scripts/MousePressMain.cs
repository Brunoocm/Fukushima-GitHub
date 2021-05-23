using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePressMain : MonoBehaviour
{
    public bool oi;
    public bool[] resposta;

    public GameObject[] objects;

    void Start()
    {

    }

    void Update()
    {
        oi = TaCerto();


    }

    private bool TaCerto()
    {
        for (int i = 0; i < objects.Length; i++)
        {
            if (resposta[i] != objects[i].GetComponent<MousePress>().ponto)
            {
                return false;

            }
            else
            {

            }
        }
        return true;

    }
}
