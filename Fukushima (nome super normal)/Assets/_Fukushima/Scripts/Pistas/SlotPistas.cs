using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SlotPistas : MonoBehaviour, IPointerClickHandler
{
    public bool isEscritorioMarido, isEscritorioDelegado, isQuartel, isCasa;


    [Header("Values")]
    public bool isSet;
    public bool correct;

    Image image;

    void Start()
    {
        image = gameObject.GetComponent<Image>();
    }

    void Update()
    {
        if(isEscritorioMarido)
        {

        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        isSet = true;
        image.color = Color.green;

        PistaMain[] pistaScripts = FindObjectsOfType(typeof(PistaMain)) as PistaMain[];

        for (int i = 0; i < pistaScripts.Length; i++)
        {

            if(pistaScripts[i].active)
            {
                image.sprite = pistaScripts[i].pistaImage.gameObject.GetComponent<Image>().sprite;

                if (pistaScripts[i].m_escritorioMarido && isEscritorioMarido) correct = true;
                else if (pistaScripts[i].m_escritorioDelegado && isEscritorioDelegado) correct = true;
                else if(pistaScripts[i].m_quartel && isQuartel) correct = true;
                else if(pistaScripts[i].m_casa && isCasa) correct = true;
                else
                {
                    correct = false;
                }
              

                print(correct);
                print("setou image");
            }
        }
       
        


    }

    public void Desativar()
    {
        isSet = false;
        image.color = Color.red;

    }
}
