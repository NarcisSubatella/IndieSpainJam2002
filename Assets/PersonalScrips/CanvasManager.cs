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
    private int wrathInt;
    private void Start()
    {
        wrahtSlider.maxValue = GameManager.current.maxWrath; 
        wrahtSlider.value = GameManager.current.maxWrath; 
    }
    private void LateUpdate()
    {
        wrathInt = (int)GameManager.current.maxWrath;

        wrahtSlider.value = GameManager.current.maxWrath;
        wrathTxt.text = wrathInt.ToString()+"%";
    }
}
