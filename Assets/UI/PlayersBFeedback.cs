using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PlayersBFeedback : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    MenuManager menu;
    TextMeshProUGUI textmeshPro;
    bool soundPlayed = false;
    // Start is called before the first frame update
    void Awake()
    {
        menu = GameObject.FindGameObjectWithTag("MenuController").GetComponent<MenuManager>();
       
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        if (soundPlayed == false)
        {
            menu.HoverButton();
            LeanTween.scale(this.gameObject, new Vector3(1.20f, 1.20f, 1.20f), 0.2f).setEaseInOutCubic();
            soundPlayed = true;
        }
    }
    public void OnPointerDown(PointerEventData pointerEventData)
    {
        print("AQUI NO ENTRA");
        
        LeanTween.scale(this.gameObject, new Vector3(1f, 1f, 1f), 0.2f).setEaseInOutCubic();
        soundPlayed = false;

    }

    public void OnPointerExit(PointerEventData pointerEventData)
    {
        
        LeanTween.scale(this.gameObject, new Vector3(1f, 1f, 1f), 0.2f).setEaseInOutCubic();
        soundPlayed = false;
    }
    

}

