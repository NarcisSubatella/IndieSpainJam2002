using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsSystem : MonoBehaviour
{
    public List <Items> itemsDestroyed;

    public void CountDestroyObject(ItemsSO item)
    {
        bool placed = false;

        for(int i=0; i<itemsDestroyed.Count;i++)
        {
            if (itemsDestroyed[i].itemName == item.itemName)
            {
                placed = true;
                itemsDestroyed[i].quiatity++;
            }

        }
        if(!placed)
        {
            Items nItem = new Items();
            nItem.itemName = item.itemName;
            nItem.quiatity = 1;

            itemsDestroyed.Add(nItem);
        }
    }

}
