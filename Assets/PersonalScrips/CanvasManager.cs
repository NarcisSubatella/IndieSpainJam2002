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
    [SerializeField] private Image characterSpriteHolder;
    private int wrathInt;
    private void Start()
    {
        wrahtSlider.maxValue = playeHealth.InitialHealth; 
        wrahtSlider.value = playeHealth.InitialHealth;
        characterSpriteHolder.sprite = GameManager.current.charactersInfo[PlayerPrefs.GetInt("PJ1")-1].characterImg;
    }
    private void LateUpdate()
    {
        wrathInt = (int)playeHealth.CurrentHealth;

       wrahtSlider.value = playeHealth.CurrentHealth;
        wrathTxt.text = wrathInt.ToString()+"%";
    }
}
