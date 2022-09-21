using MoreMountains.TopDownEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowItem : MonoBehaviour
{
    public WeaponsSO weapon;
    [SerializeField] int currentlife;
    private Rigidbody2D rigidBody;
    //public bool picked = false;

  //  private PickableWeapon weaponPicker;

    private void Start()
    {
       // currentlife = weapon.life;
       // GetComponent<SpriteRenderer>().sprite = weapon.sprite;
        rigidBody = GetComponent<Rigidbody2D>();

        // weaponPicker = GetComponent<PickableWeapon>();
        //weaponPicker.enabled = false;
        //GetComponent<Collider2D>().enabled = false;
    }
    /*private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && collision.GetComponent<Player>().grabingObject == false)
        {
            if (picked == false)
            {
                if (Input.GetButton("Player1_Interact"))
                {
                    if (weapon.weaponType == weaponsType.ThrowItem)
                    {
                        GetingItem(collision.GetComponent<Player>().topPos);
                    }
                    if (weapon.weaponType == weaponsType.Mele)
                    {
                        GetingItem(collision.GetComponent<Player>().sidePos);
                    }
                }
            }
        }
    }*/

    private void GetingItem(Transform pos)
    {
        rigidBody.isKinematic=true;
        transform.SetParent(pos);
        transform.localPosition = Vector2.zero;
        StartCoroutine(boolActive());
        GetComponentInParent<Player>().grabingObject = true;
        GetComponentInParent<Player>().objectGrabed = this.gameObject;
    }
   /* private void LateUpdate()
    {
        if(Input.GetButton("Player1_Interact")/* && GetComponentInParent<Player>().objectGrabs == this.gameObject*/// && this.gameObject == GetComponentInParent<Character>().objectGraping)
        //{
            
       // }
  //  }*/
    public void ThrowObject()
    {
        Physics2D.IgnoreLayerCollision(10, 23, true);

        gameObject.SetActive(true);

        transform.SetParent(GetComponentInParent<Player>().sidePos);
        transform.localPosition = Vector2.zero;
        rigidBody.AddForce(GetComponentInParent<Player>().directionThrow * weapon.throwForce, ForceMode2D.Impulse);
        GetComponentInParent<Character>().objectGraping = null;
        transform.SetParent(null);
        StartCoroutine(colliderActive());
    }
    IEnumerator boolActive()
    {
        yield return new WaitForSeconds(0.5f);
        //picked = true;
    }
    IEnumerator colliderActive()
    {
        yield return new WaitForSeconds(0.1f);
        GetComponent<Collider2D>().enabled = true;
        Physics2D.IgnoreLayerCollision(10, 23, false);
    }
    
}

