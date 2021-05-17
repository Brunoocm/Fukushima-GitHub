using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PickUpItem : InteractableBase
{
    [Header("Inventory Data")]
    public InventoryObject inventory;
    public ItemObject item;

    private PistasSpawn pistaScript;

    [TextArea] public string[] playerFala;
    private int index = 0;
    private bool set;
    private float timerFala;
    TextMeshProUGUI TextForPistas;

    private MeshRenderer mesh;
    private void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        TextForPistas = GameObject.Find("TextForPistas").GetComponentInChildren<TextMeshProUGUI>();

        pistaScript = FindObjectOfType<PistasSpawn>();

        item.hasObjectItem = false;

    }

    void Update()
    {
        timer();

    }
    public override void OnInteract()
    {
        base.OnInteract();
        StartCoroutine(TrueVoid());

        if (item)
        {
            inventory.AddItem(item, 1);
            //Destroy(gameObject);
            print(item.objectName);
            pistaScript.LocalAtualizado();
            mesh.enabled = false;


        }

        if (base.HasMission)
        {
            GameObject obj = GameObject.Find("Mission Controller");
            obj.GetComponent<MissionContoller>().MissaoCompleta();
        }

    }


    IEnumerator TrueVoid()
    {
        yield return new WaitForSeconds(0.5f);
        set = true;

    }

    void timer()
    {
        int num = playerFala.Length;

        if (set)
        {
            if (index < num && timerFala <= 0)
            {
                TextForPistas.text = playerFala[index];
                timerFala = 5;


                index++;


            }
            else if (index == num && timerFala <= 0)
            {
                set = false;
                TextForPistas.text = "";
                Destroy(gameObject);
            }

            timerFala -= Time.deltaTime;
        }


    }


}
