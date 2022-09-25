using MoreMountains.Feedbacks;
using MoreMountains.TopDownEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemsSettings : MonoBehaviour
{
    public ItemsSO item;
    public bool contactPlace;
    public TextMeshProUGUI price;

    public void GetPoints()
    {
        GameManager.current.gameObject.GetComponent<PointsSystem>().CountDestroyObject(item);
    }
    private void Awake()
    {
        if (contactPlace)
        {
            gameObject.layer = LayerMask.NameToLayer("ItemNoDetect");

        }
     
    }
    private void Start()
    {
        
      //  price = transform.Find("PointShowTxt").GetComponent< TextMeshProUGUI>();

      //  price.gameObject.SetActive(true);
       // price.text = item.pointToDestroy.ToString();
      //  price.gameObject.SetActive(false);
    }
    public void PickUpGetItemLayer()
    {
        gameObject.layer = LayerMask.NameToLayer("Item");
        transform.SetParent(null);
    }
    public void BreakJoin()
    {
        GetPrice();
        if(contactPlace)
        {

            Invoke("BreakInvoque", 1);
          
        }
        GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
        if(GetComponent<PickableWeapon>())
        {
        Destroy(GetComponent<PickableWeapon>());
        }
    }
    private void BreakInvoque()
    {
        if(transform.parent !=null)
        {
            if(GetComponentInParent<RelativeJoint2D>())
            {
                GetComponentInParent<RelativeJoint2D>().enabled = false;
            }
            transform.SetParent(null);
        }
    }
    private void GetPrice()
    {
        price.text = item.pointToDestroy.ToString();
        price.gameObject.GetComponentInParent<Animator>().SetTrigger("AnimOn");
    }
}
