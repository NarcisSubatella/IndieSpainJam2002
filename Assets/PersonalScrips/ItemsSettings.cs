using MoreMountains.Feedbacks;
using MoreMountains.TopDownEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsSettings : MonoBehaviour
{
    public ItemsSO item;

    public void GetPoints()
    {
        GameManager.current.gameObject.GetComponent<PointsSystem>().CountDestroyObject(item);
    }
}
