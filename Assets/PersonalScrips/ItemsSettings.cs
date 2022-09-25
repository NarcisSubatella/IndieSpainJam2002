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

    [SerializeField] Weapon weaponToWear;
    [SerializeField] int spritepos;
    
    [Header("EffectsHolder")]
    [SerializeField] private MMFeedbacks destroy;
    [SerializeField] private MMFeedbacks damage;
    [SerializeField] private MMFeedbacks pickUP;

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
        //que pasa al destriur

        //Que no se pueda recoger
        GetComponent<PickableWeapon>().enabled = false;
        gameObject.layer = LayerMask.NameToLayer("ItemNoDetect");
        pickUP.gameObject.layer = LayerMask.NameToLayer("Obstacles");
        transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite = item.sprites[spritepos].Break;

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
        GetComponent<PickableWeapon>().PickedMMFeedbacks = pickUP;
        GetComponent<PickableWeapon>().WeaponToGive = weaponToWear;


        destroy.Feedbacks[0].GetComponent<MMFeedbackMaterial>().TargetRenderer = transform.GetChild(0).GetComponent<SpriteRenderer>();

    }
}
