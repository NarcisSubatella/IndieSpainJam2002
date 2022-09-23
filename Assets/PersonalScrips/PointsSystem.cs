using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointsSystem : MonoBehaviour
{
    public List <Items> itemsDestroyed;
    public int totalPoints = 0;
    public bool timeToCount = false;
    [SerializeField]float speedCount = 1;
    [SerializeField] TextMeshProUGUI oText;
    [SerializeField] TextMeshProUGUI qText;
    [SerializeField] TextMeshProUGUI pText;
    [SerializeField] TextMeshProUGUI fpText;

    float currentsPoint;
    int priceToShow;

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
            nItem.price = item.pointToDestroy;

            itemsDestroyed.Add(nItem);
        }
        totalPoints += item.pointToDestroy;
    }

    private void LateUpdate()
    {
        if(timeToCount)
        {
            timeToCount = false;
            Counting();
        }
    }
    private void Counting()
    {
        foreach(Items item in itemsDestroyed)
        {
            oText.text += item.itemName + "\n"; 
            qText.text += "X" + item.quiatity.ToString() + "\n"; 
            pText.text += item.price + " $" + "\n"; 
        }
        while(currentsPoint<totalPoints)
        {
            currentsPoint += (Time.deltaTime*speedCount);
            priceToShow = (int)currentsPoint;
            fpText.text = priceToShow.ToString();
        }
    }
    
}
