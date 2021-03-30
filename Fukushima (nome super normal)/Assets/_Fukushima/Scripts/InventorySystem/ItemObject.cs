using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class ItemObject : ScriptableObject
{
    public GameObject prefab;
    public GameObject prefabModel;
    public Sprite objectSprite;
    public string objectName;
    public bool hasObjectItem;
    
}
