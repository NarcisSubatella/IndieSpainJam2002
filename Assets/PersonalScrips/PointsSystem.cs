using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using MoreMountains.TopDownEngine;

namespace MoreMountains.TopDownEngine
{
    public class PointsSystem : MonoBehaviour
    {
        public List<Items> itemsDestroyed;
        public int totalPoints = 0;
        public bool timeToCount = false;
        [SerializeField] float speedCount = 1;
        [SerializeField] TextMeshProUGUI oText;
        [SerializeField] TextMeshProUGUI qText;
        [SerializeField] TextMeshProUGUI pText;
        [SerializeField] TextMeshProUGUI fpText;
        [SerializeField] GameObject countingPanel;

        [SerializeField] private Health playerHeals;
        [SerializeField] private float decreaseSpeed = 0.1f;

        float currentsPoint;
        int priceToShow;

        private void Start()
        {
            playerHeals = GameObject.FindGameObjectWithTag("Player").GetComponent<Health>();
         


        }
        public void CountDestroyObject(ItemsSO item)
        {
            bool placed = false;

            for (int i = 0; i < itemsDestroyed.Count; i++)
            {
                if (itemsDestroyed[i].itemName == item.itemName)
                {
                    placed = true;
                    itemsDestroyed[i].quiatity++;
                }

            }
            if (!placed)
            {
                Items nItem = new Items();
                nItem.itemName = item.itemName;
                nItem.quiatity = 1;
                nItem.price = item.pointToDestroy;

                itemsDestroyed.Add(nItem);
            }
            totalPoints += item.pointToDestroy;
        }

       

    
       /* public void WrahtCountDown()
        {
            if (GameManager.current.startDestroing)
            {
                Debug.Log(playerHeals.CurrentHealth);
                //maxWrath -= decreaseSpeed * Time.deltaTime;
                playerHeals.CurrentHealth -= decreaseSpeed * Time.deltaTime;
                if (playerHeals.CurrentHealth <= 0)
                {
                    
                    GameManager.current.startDestroing = false;
                    timeToCount = true;
                }
            }
        }*/
        private void Update()
        {
            if(!timeToCount)
            {

                playerHeals.CurrentHealth -= Time.deltaTime * decreaseSpeed;
                if (playerHeals.CurrentHealth <= 0)
                {
                    Debug.Log("ENTRO");
                    timeToCount=true;
                    Counting();


                }


            }

           

        }
        public void Counting()
        {
            countingPanel.SetActive(true);
            foreach (Items item in itemsDestroyed)
            {
                oText.text += item.itemName + "\n";
                qText.text += "X" + item.quiatity.ToString() + "\n";
                pText.text += item.price + " $" + "\n";
            }
            while (currentsPoint < totalPoints)
            {
                currentsPoint += (Time.deltaTime * speedCount);
                priceToShow = (int)currentsPoint;
                fpText.text = priceToShow.ToString();
            }
        }

    }
}