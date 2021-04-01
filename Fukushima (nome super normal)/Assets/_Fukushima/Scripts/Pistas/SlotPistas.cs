using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SlotPistas : MonoBehaviour, IPointerClickHandler
{
    public bool isSet;

    public int correctNumber;

    Image image;
    // Start is called before the first frame update
    void Start()
    {
        image = gameObject.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnPointerClick(PointerEventData eventData)
    {
        isSet = true;
        image.color = Color.green;
    }

    public void Desativar()
    {
        isSet = false;
        image.color = Color.red;

    }
}
