using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Interaction Data", menuName = "InteractionSystem/InteractionData")]
public class InteractionData : ScriptableObject
{
    private InteractableBase m_interactable;

    public InteractableBase Interactable
    {
        get => m_interactable;
        set => m_interactable = value;
    }


    public bool IsSameInteractable(InteractableBase _newInteractable) => m_interactable == _newInteractable;
    public bool IsEmpty() => m_interactable == null;
    public void ResetData() => m_interactable = null;

    public void Interact()
    {
        m_interactable.OnInteract(); //seta quando interage
        ResetData();
    }


}
