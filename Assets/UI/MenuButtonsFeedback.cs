using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MenuButtonsFeedback : MonoBehaviour
{
    MenuManager menu;
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

    /*
    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        print("HOLA CABRON");
    }
    public void OnPointerExit(PointerEventData pointerEventData)
    {
        print("ADIOS CABRON");
    }
    
    private void OnMouseOver()
    {
        print("HOLA CABRON");
        if (soundPlayed == false)
        {
            
            menu.HoverButton();
            LeanTween.scale(this.gameObject, new Vector3(0.10f, 0.10f, 0.10f), 0.2f).setEaseInOutCubic();
            soundPlayed = true;
        }
    }
    private void OnMouseExit()
    {
        print("HOLA POLLA");
        LeanTween.scale(this.gameObject, new Vector3(0.65f, 0.65f, 0.65f), 0.2f).setEaseInOutCubic();
        soundPlayed = false;
    }*/

}
