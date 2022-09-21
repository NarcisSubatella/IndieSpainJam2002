using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Weapon", menuName ="Items/Weapons")]
public class WeaponsSO : ScriptableObject
{
    public string itemName;
    public int id;
    public weaponsType weaponType;
    public int life;
    public float force;
    public float chargedForce;
    public float throwForce;
    public GameObject prefab;
    public Sprite sprite;
    


}
