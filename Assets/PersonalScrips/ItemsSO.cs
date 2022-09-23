using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Item/Item")]
public class ItemsSO : ScriptableObject
{
    public string itemName;
    public int id;
    public weaponsType weaponType;
    public float throwForce;
    public int pointToDestroy;
}
