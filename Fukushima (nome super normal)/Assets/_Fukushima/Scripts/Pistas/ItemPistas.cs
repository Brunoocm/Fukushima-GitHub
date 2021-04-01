using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemPistas : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private Transform slotsPivot;

    [SerializeField] private GameObject[] slot;

    public int numerPista;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        slot = new GameObject[slotsPivot.transform.childCount];
        for (int i = 0; i < slotsPivot.transform.childCount; i++)
        {
            slot[i] = slotsPivot.transform.GetChild(i).gameObject;

        }

       
    }

    public void SetarNumber()
    {
      
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (slot[0].gameObject.GetComponent<SlotPistas>().isSet)
        {
            slot[0].gameObject.GetComponent<SlotPistas>().correctNumber = numerPista;
        }
        else if (slot[1].gameObject.GetComponent<SlotPistas>().isSet)
        {
            slot[1].gameObject.GetComponent<SlotPistas>().correctNumber = numerPista;
        }
        else if (slot[2].gameObject.GetComponent<SlotPistas>().isSet)
        {
            slot[2].gameObject.GetComponent<SlotPistas>().correctNumber = numerPista;
        }
        else
        {

        }
    }
}
