using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class PickUpPistas : InteractableBase
{

    [Header("Inventory Data")]
    public bool hasPista;
    public GameObject prefabPistas;
    public InteractionUIPanel UIText;

    [TextArea] public string[] playerFala;
    private int index = 0;
    private bool set;
    private float timerFala;


    private Camera mainCam;

    private GameObject clickedObject;
    private GameObject fixPos;
    private bool examineMode = false;
    private bool umaVez;
    private PistasSpawn pistaScript;
    TextMeshProUGUI TextForPistas;
    FirstPersonController controller;

    Vector3 originaPosition;
    Vector3 originalRotation;

    public bool hasEvent;
    [SerializeField] private UnityEvent m_Event;

    private void Awake()
    {
        TextForPistas = GameObject.Find("TextForPistas").GetComponentInChildren<TextMeshProUGUI>();
        controller = FindObjectOfType<FirstPersonController>();
    }
    private void Start()
    {
        pistaScript = FindObjectOfType<PistasSpawn>();

        mainCam = Camera.main;
        fixPos = GameObject.Find("InspectPos");
    }
    public override void OnInteract()
    {
        base.OnInteract();
        Spawn();
        ClickObject();

        if(hasEvent) m_Event.Invoke();

        if (base.HasMission)
        {
            GameObject obj = GameObject.Find("Mission Controller");
            obj.GetComponent<MissionContoller>().MissaoCompleta();
        }
    }

    private void Update()
    {
        TurnObject();

        ExitExamineMode();

        timer();
    }

    void Spawn()
    {
        if (!umaVez)
        {
            for (int i = 0; i < pistaScript.pistasPivotSpawner.Length; i++)
            {
                if (hasPista)
                {
                    GameObject spawn = Instantiate(prefabPistas, pistaScript.pistasPivotSpawner[i].transform.position, pistaScript.pistasPivotSpawner[i].transform.rotation);
                    spawn.transform.parent = pistaScript.pistasPivotSpawner[i].transform;
                    if (hasPista) pistaScript.SpawnPista();
                    if (!hasPista) pistaScript.LocalAtualizado();

                }

                StartCoroutine(TrueVoid());
            }
            umaVez = true;
        }
    }



    void ClickObject()
    {
        if (!examineMode)
        {
            controller.cameraCanMove = false;


            clickedObject = transform.gameObject;
            originaPosition = clickedObject.transform.position;
            originalRotation = clickedObject.transform.rotation.eulerAngles;
            clickedObject.transform.position = fixPos.transform.position;


            Time.timeScale = 0;

            examineMode = true;

        }

    }

    void TurnObject()
    {
        if (Input.GetMouseButton(0) && examineMode)
        {

            float rotationSpeed = 15;

            float xAxis = Input.GetAxis("Mouse X") * rotationSpeed;
            float yAxis = Input.GetAxis("Mouse Y") * rotationSpeed;

            clickedObject.transform.Rotate(Vector3.up, -xAxis, Space.World);
            clickedObject.transform.Rotate(Vector3.right, yAxis, Space.World);

            UIText.ResetUI();
        }

    }

    void ExitExamineMode()
    {
        if (Input.GetMouseButtonDown(1) && examineMode)
        {
            controller.cameraCanMove = true;

            Time.timeScale = 1;
            clickedObject.transform.position = originaPosition;
            clickedObject.transform.eulerAngles = originalRotation;

            examineMode = false;
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
            else if(index == num && timerFala <= 0)
            {
                set = false;
                TextForPistas.text = "";
            }

            timerFala -= Time.deltaTime;
        }
        

    }
}
