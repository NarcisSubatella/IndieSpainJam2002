using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MenuButtonsFeedback : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    MenuManager menu;
    TextMeshProUGUI textmeshPro;
    bool soundPlayed = false;
    // Start is called before the first frame update
    void Awake()
    {
        menu = GameObject.FindGameObjectWithTag("MenuController").GetComponent<MenuManager>();
        textmeshPro = transform.GetChild(0).gameObject.GetComponent<TMPro.TextMeshProUGUI>();
        textmeshPro.color = new Color32(255, 162, 0, 255);
        PlayerPrefs.SetInt("PJ1", 0);
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        if (soundPlayed == false)
        {
            
            textmeshPro.color = new Color32(255, 255, 255, 255);
            menu.HoverButton();
            LeanTween.scale(transform.GetChild(0).gameObject, new Vector3(1.20f, 1.20f, 1.20f), 0.2f).setEaseInOutCubic();
            soundPlayed = true;
        }
    }
    public void OnPointerDown(PointerEventData pointerEventData)
    {
        print("AQUI NO ENTRA");
        textmeshPro.color = new Color32(255, 162, 0, 255);
        LeanTween.scale(transform.GetChild(0).gameObject, new Vector3(1f, 1f, 1f), 0.2f).setEaseInOutCubic();
        soundPlayed = false;

    }

    public void OnPointerExit(PointerEventData pointerEventData)
    {
        textmeshPro.color = new Color32(255, 162, 0, 255);
        LeanTween.scale(transform.GetChild(0).gameObject, new Vector3(1f, 1f, 1f), 0.2f).setEaseInOutCubic();
        soundPlayed = false;
    }

    public void ReturnToNormal()
    {
        textmeshPro.color = new Color32(255, 255, 255, 255);
        menu.HoverButton();
        LeanTween.scale(transform.GetChild(0).gameObject, new Vector3(1.20f, 1.20f, 1.20f), 0.2f).setEaseInOutCubic();
        soundPlayed = false;
    }
    /*
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
