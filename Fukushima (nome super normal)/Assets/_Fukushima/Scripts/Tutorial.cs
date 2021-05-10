using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class Tutorial : MonoBehaviour
{

    public string[] sentences;
    public UnityEvent[] eventosText;
    private int number;

    TextMeshProUGUI text;
    GameObject tutorialGameobject;
    public Animator anim;
    void Start()
    {
        tutorialGameobject = GameObject.Find("TextTutorial"); 
        anim = tutorialGameobject.GetComponent<Animator>();
        text = tutorialGameobject.GetComponentInChildren<TextMeshProUGUI>();
        text.text = sentences[number];
        eventosText[number].Invoke();
    }

    void Update()
    {
       
    }

    void NextSentece()
    {
        anim.SetTrigger("Next");
        number++;
        text.text = sentences[number];
        eventosText[number].Invoke();



    }
}
