using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PistaMain : MonoBehaviour, IPointerClickHandler
{

    public bool active;
    public ScriptablePistas pista;
    public GameObject pistaImage;

    private bool m_active;
    private string m_pistaName;
    public bool m_escritorioMarido, m_escritorioDelegado, m_quartel, m_casa;

    private void Awake()
    {
        m_escritorioMarido = pista.escritorioMarido;
        m_escritorioDelegado = pista.escritorioDelegado;
        m_quartel = pista.quartel;
        m_casa = pista.casa;

    }
    void Start()
    {
        pistaImage.GetComponent<Image>().sprite = pista.objectImage;
        m_pistaName = pista.pistaName;



    }

    void Update()
    {
        active = m_active;


    }

    public void OnPointerClick(PointerEventData eventData)
    {
        PistaMain[] pistaScripts = FindObjectsOfType(typeof(PistaMain)) as PistaMain[];

        for (int i = 0; i < pistaScripts.Length; i++)
        {
            pistaScripts[i].m_active = false;
        }
        m_active = true;
    }
}
