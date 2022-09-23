using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpWeapons : MonoBehaviour
{
    private ItemsSO weapon;
    private bool pickeable = true;

    private void Start()
    {
        weapon = GetComponent<ThrowItem>().weapon;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            if(pickeable)
            {

                Debug.Log("B");
                if(Input.GetButton("Player1_Shoot"))
                {
                    if(weapon.weaponType==weaponsType.ThrowItem)
                    {
                        transform.SetParent(collision.transform.Find("TopPos").transform);
                        transform.localPosition = Vector2.zero;
                    }
                    if(weapon.weaponType == weaponsType.Mele)
                    {
                        transform.SetParent(collision.transform.Find("SidePos").transform);
                        transform.localPosition = Vector2.zero;
                    }
                    pickeable = false;
                    Debug.Log("A");
                }
            }
        }
    }
    private void LateUpdate()
    {
        
    }
}
