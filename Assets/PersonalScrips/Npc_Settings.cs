using MoreMountains.TopDownEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Npc_Settings : MonoBehaviour
{
    public TextMeshProUGUI price;
    public int points;
    public void GetPrice()
    {
        price.text = points.ToString();
        price.gameObject.GetComponentInParent<Animator>().SetTrigger("AnimOn");
    }

}
