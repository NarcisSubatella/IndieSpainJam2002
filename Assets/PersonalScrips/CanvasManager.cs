using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using MoreMountains.TopDownEngine;

public class CanvasManager : MonoBehaviour
{
    [SerializeField] private Slider wrahtSlider;
    [SerializeField] private TextMeshProUGUI wrathTxt;
    [SerializeField] private Health playeHealth;
    private int wrathInt;
    private void Start()
    {
        wrahtSlider.maxValue = playeHealth.InitialHealth; 
        wrahtSlider.value = playeHealth.InitialHealth; 
    }
    private void LateUpdate()
    {
        wrathInt = (int)playeHealth.CurrentHealth;

       wrahtSlider.value = playeHealth.CurrentHealth;
        wrathTxt.text = wrathInt.ToString()+"%";
    }
}
