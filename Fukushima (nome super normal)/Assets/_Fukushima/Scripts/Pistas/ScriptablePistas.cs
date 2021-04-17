using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "pista", menuName = "Inventory System/ Pista")]
public class ScriptablePistas : ScriptableObject
{

    public Sprite objectImage;
    public string pistaName;

  
    public bool escritorioMarido, escritorioDelegado, quartel, casa; 


}
