using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainPistas : MonoBehaviour
{
    [SerializeField] private Transform MissionParque;
    [SerializeField] private Transform MissionQuartelG;
    [SerializeField] private Transform MissionEscritorio;
    [SerializeField] private Transform MissionCasa;


    [SerializeField] private  GameObject[] parque;
    [SerializeField] private  GameObject[] quartelG;
    [SerializeField] private  GameObject[] escritorio;
    [SerializeField] private  GameObject[] casa;


    private int pistasInt;


    void Update()
    {
        parque = new GameObject[MissionParque.transform.childCount];
        for (int i = 0; i < MissionParque.transform.childCount; i++)
        {
            parque[i] = MissionParque.transform.GetChild(i).gameObject;
            
            //parque[i] = gameObject.GetComponent<SlotPistas>();
        }
        if (parque[0].gameObject.GetComponent<SlotPistas>().correctNumber == 1) print("parqueA");
        if (parque[1].gameObject.GetComponent<SlotPistas>().correctNumber == 2) print("parqueb");
        if (parque[2].gameObject.GetComponent<SlotPistas>().correctNumber == 3) print("parquec");


        quartelG = new GameObject[MissionQuartelG.transform.childCount];
        for (int i = 0; i < MissionQuartelG.transform.childCount; i++)
        {
            quartelG[i] = MissionQuartelG.transform.GetChild(i).gameObject;
        }
        if (quartelG[0].gameObject.GetComponent<SlotPistas>().correctNumber == 4) print("quartelGA");
        if (quartelG[1].gameObject.GetComponent<SlotPistas>().correctNumber == 5) print("quartelGb");
        if (quartelG[2].gameObject.GetComponent<SlotPistas>().correctNumber == 6) print("quartelGc");

        escritorio = new GameObject[MissionEscritorio.transform.childCount];
        for (int i = 0; i < MissionEscritorio.transform.childCount; i++)
        {
            escritorio[i] = MissionEscritorio.transform.GetChild(i).gameObject;
        }
        if (escritorio[0].gameObject.GetComponent<SlotPistas>().correctNumber == 7) print("escritorioA");
        if (escritorio[1].gameObject.GetComponent<SlotPistas>().correctNumber == 8) print("escritoriob");
        if (escritorio[2].gameObject.GetComponent<SlotPistas>().correctNumber == 9) print("escritorioc");

        casa = new GameObject[MissionCasa.transform.childCount];
        for (int i = 0; i < MissionCasa.transform.childCount; i++)
        {
            casa[i] = MissionCasa.transform.GetChild(i).gameObject;
        }
        if (casa[0].gameObject.GetComponent<SlotPistas>().correctNumber == 10) print("casaA");
        if (casa[1].gameObject.GetComponent<SlotPistas>().correctNumber == 11) print("casab");
        if (casa[2].gameObject.GetComponent<SlotPistas>().correctNumber == 12) print("casac");

    }


    public void SetSlot(string name)
    {

    }
}

