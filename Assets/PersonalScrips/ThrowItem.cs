using MoreMountains.TopDownEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowItem : MonoBehaviour
{
    public ItemsSO weapon;
    private Rigidbody2D rigidBody;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();      
    }
    

    private void GetingItem(Transform pos)
    {
        rigidBody.isKinematic=true;
        transform.SetParent(pos);
        transform.localPosition = Vector2.zero;
        StartCoroutine(boolActive());
        GetComponentInParent<Player>().grabingObject = true;
        GetComponentInParent<Player>().objectGrabed = this.gameObject;
    }
   
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

