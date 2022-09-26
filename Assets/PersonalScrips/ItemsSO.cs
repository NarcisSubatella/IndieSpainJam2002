using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Item/Item")]
public class ItemsSO : ScriptableObject
{
    public string itemName;
    public int id;
    public weaponsType weaponType;
    public int pointToDestroy;
    public SpriteGruops[] sprites;

    [Header("Pickup Objects")]
    public float throwForce;
    public int throwDamage;
}
[Serializable]
public class SpriteGruops
{
    public string namePoss;
    public int life;
    public Sprite noBreak;
    public Sprite Break;
}