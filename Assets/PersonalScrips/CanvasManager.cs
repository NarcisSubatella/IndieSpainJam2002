using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CanvasManager : MonoBehaviour
{
    [SerializeField] private Slider wrahtSlider;
    [SerializeField] private TextMeshProUGUI wrathTxt;
    private int wrathInt;
    private void Start()
    {
        wrahtSlider.maxValue = GameManagerS.curret.maxWrath; 
        wrahtSlider.value = GameManagerS.curret.maxWrath; 
    }
    private void LateUpdate()
    {
        wrathInt = (int)GameManagerS.curret.maxWrath;

        wrahtSlider.value = GameManagerS.curret.maxWrath;
        wrathTxt.text = wrathInt.ToString()+"%";
    }
}
