using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Classes : MonoBehaviour
{

}
public enum weaponsType
{
    None,
    ThrowItem,
    Mele,
    Range
}

[Serializable]
public class Items
{
    public string itemName;
    public int quiatity;
    public int price;

}