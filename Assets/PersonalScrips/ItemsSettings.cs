using MoreMountains.Feedbacks;
using MoreMountains.TopDownEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsSettings : MonoBehaviour
{
    public ItemsSO item;
    public bool contactPlace;

    public void GetPoints()
    {
        GameManager.current.gameObject.GetComponent<PointsSystem>().CountDestroyObject(item);
    }
    private void Awake()
    {
        if (contactPlace)
        {
            gameObject.layer = LayerMask.NameToLayer("ItemNoDetect");
           /* foreach (Transform child in transform)
            {
                child.gameObject.layer = 19;
            }*/

        }
    }
    public void GetItemLayer()
    {
        gameObject.layer = LayerMask.NameToLayer("Item");
    }
}
