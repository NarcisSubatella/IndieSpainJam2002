using MoreMountains.Feedbacks;
using MoreMountains.TopDownEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemsSettings : MonoBehaviour
{
    public ItemsSO item;
    public TextMeshProUGUI price;

    public bool contactPlace;
    [SerializeField] private bool pickableObject = false; 

    [SerializeField] Weapon weaponToWear;
    [SerializeField] int spritepos;
    
    //Holders de los effectos
    private GameObject destroy;
    private GameObject damage;
    private GameObject pickUP;

    public void GetPoints()
    {
        GameManager.current.gameObject.GetComponent<PointsSystem>().CountDestroyObject(item);
    }
    private void Awake()
    {
        if(gameObject.layer != LayerMask.NameToLayer("Obstacles"))
        {
            if (!contactPlace)
            {
              //  gameObject.layer = LayerMask.NameToLayer("Item");
                SetGameLayerRecursive(this.gameObject, 23);

            }
            else
            {
               // gameObject.layer = LayerMask.NameToLayer("ItemNoDetect");
                SetGameLayerRecursive(this.gameObject, 24);
            }
        }
     
        Inicialite();
    }
    private void Start()
    {
    }
    public void PickUpGetItemLayer()
    {
        SetGameLayerRecursive(this.gameObject, 23);
        transform.SetParent(null);
    }
    public void BreakJoin()
    {
        GetPrice();
        // GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
        GetPoints();
        if(contactPlace)
        {

            Invoke("BreakInvoque", 1);
          
        }
        if(GetComponent<PickableWeapon>())
        {
        Destroy(GetComponent<PickableWeapon>());
        }
    }
    private void BreakInvoque()
    {
        //que pasa al destriur

        //Que no se pueda recoger
      /*  if (GetComponent<PickableWeapon>())
        {
            GetComponent<PickableWeapon>().enabled = false;
        }*/
        //cambiar layers
        gameObject.layer = LayerMask.NameToLayer("ItemNoDetect");
        pickUP.gameObject.layer = LayerMask.NameToLayer("Obstacles");

        transform.GetChild(1).gameObject.GetComponent<SpriteRenderer>().sprite = item.sprites[spritepos].Break;

        if (transform.parent !=null)
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

    private void SetGameLayerRecursive(GameObject _go, int _layer)
    {
        _go.layer = _layer;
        foreach (Transform child in _go.transform)
        {
            child.gameObject.layer = _layer;

            Transform _HasChildren = child.GetComponentInChildren<Transform>();
            if (_HasChildren != null)
                SetGameLayerRecursive(child.gameObject, _layer);

        }
    }

    private void Inicialite()
    {
        price = transform.GetChild(0).GetChild(1).GetComponentInChildren<TextMeshProUGUI>();

        //Asignar holders de los feedbacks
        destroy = transform.GetChild(0).GetChild(0).Find("DestroyFeedBack").gameObject;
        damage = transform.GetChild(0).GetChild(0).Find("DamageFeedBack").gameObject;

        //solo objetos equipables
        if (pickableObject)
        {
            pickUP = transform.GetChild(0).GetChild(0).Find("FeedBackPickUp").gameObject;
            //Asignar arma
            GetComponent<PickableWeapon>().WeaponToGive = weaponToWear;
            GetComponent<PickableWeapon>().PickedMMFeedbacks = pickUP.GetComponent<MMFeedbacks>();

            //Assignar la localizacion del render para cambiar el material outline posteriormente
            destroy.GetComponent<MMFeedbacks>().Feedbacks[0].GetComponent<MMFeedbackMaterial>().TargetRenderer = transform.GetChild(1).GetComponent<SpriteRenderer>();

            GetComponent<ThrowItem>().weapon = item;
        }

        //healts scrips
        Health health = GetComponent<Health>();
        health.InitialHealth = item.sprites[spritepos].life;
        health.CurrentHealth = item.sprites[spritepos].life;
        health.DamageMMFeedbacks = damage.GetComponent<MMFeedbacks>();
        health.DeathMMFeedbacks = destroy.GetComponent<MMFeedbacks>();


    }
}
