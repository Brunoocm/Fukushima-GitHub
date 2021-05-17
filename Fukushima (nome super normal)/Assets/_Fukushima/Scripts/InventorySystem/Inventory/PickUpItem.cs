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

    private void Start()
    {
        TextForPistas = GameObject.Find("TextForPistas").GetComponentInChildren<TextMeshProUGUI>();

        pistaScript = FindObjectOfType<PistasSpawn>();

        item.hasObjectItem = false;

    }
    public override void OnInteract()
    {
        base.OnInteract();

        if(item)
        {
            inventory.AddItem(item, 1);
            Destroy(gameObject);
            print(item.objectName);
            pistaScript.LocalAtualizado();


            StartCoroutine(TrueVoid());
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
                timerFala = 3;


                index++;


            }
            else if (index == num && timerFala <= 0)
            {
                set = false;
                TextForPistas.text = "";
            }

            timerFala -= Time.deltaTime;
        }


    }


}
