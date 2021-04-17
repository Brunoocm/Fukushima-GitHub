using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainPistas : MonoBehaviour
{
    [SerializeField] private Transform MissionEscritorioDelegado;
    [SerializeField] private Transform MissionQuartelG;
    [SerializeField] private Transform MissionEscritorioMarido;
    [SerializeField] private Transform MissionCasa;


    [SerializeField] private  GameObject[] escritorioDelegado;
    [SerializeField] private  GameObject[] quartelG;
    [SerializeField] private  GameObject[] escritorioMarido;
    [SerializeField] private  GameObject[] casa;


    private int pistasInt;


    void Update()
    {

        escritorioDelegado = new GameObject[MissionEscritorioDelegado.transform.childCount];
        for (int i = 0; i < MissionEscritorioDelegado.transform.childCount; i++)
        {
            escritorioDelegado[i] = MissionEscritorioDelegado.transform.GetChild(i).gameObject;
            
            //parque[i] = gameObject.GetComponent<SlotPistas>();
        }
        if (escritorioDelegado[0].gameObject.GetComponent<SlotPistas>().correct == true) print("parqueA");
        if (escritorioDelegado[1].gameObject.GetComponent<SlotPistas>().correct == true) print("parqueb");
        if (escritorioDelegado[2].gameObject.GetComponent<SlotPistas>().correct == true) print("parquec");


        quartelG = new GameObject[MissionQuartelG.transform.childCount];
        for (int i = 0; i < MissionQuartelG.transform.childCount; i++)
        {
            quartelG[i] = MissionQuartelG.transform.GetChild(i).gameObject;
        }
        if (quartelG[0].gameObject.GetComponent<SlotPistas>().correct == true) print("quartelGA");
        if (quartelG[1].gameObject.GetComponent<SlotPistas>().correct == true) print("quartelGb");
        if (quartelG[2].gameObject.GetComponent<SlotPistas>().correct == true) print("quartelGc");

        escritorioMarido = new GameObject[MissionEscritorioMarido.transform.childCount];
        for (int i = 0; i < MissionEscritorioMarido.transform.childCount; i++)
        {
            escritorioMarido[i] = MissionEscritorioMarido.transform.GetChild(i).gameObject;
        }
        if (escritorioMarido[0].gameObject.GetComponent<SlotPistas>().correct == true) print("escritorioA");
        if (escritorioMarido[1].gameObject.GetComponent<SlotPistas>().correct == true) print("escritoriob");
        if (escritorioMarido[2].gameObject.GetComponent<SlotPistas>().correct == true) print("escritorioc");

        casa = new GameObject[MissionCasa.transform.childCount];
        for (int i = 0; i < MissionCasa.transform.childCount; i++)
        {
            casa[i] = MissionCasa.transform.GetChild(i).gameObject;
        }
        if (casa[0].gameObject.GetComponent<SlotPistas>().correct == true) print("casaA");
        if (casa[1].gameObject.GetComponent<SlotPistas>().correct == true) print("casab");
        if (casa[2].gameObject.GetComponent<SlotPistas>().correct == true) print("casac");

    }


    public void SetSlot(string name)
    {

    }
}

