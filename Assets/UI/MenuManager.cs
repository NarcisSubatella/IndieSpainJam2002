using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject mMenuComponents, mMenuPanel, settingsComponents, creditsComponents, surePanel, selectorPanel, sPlayersComponents, s1PlayerCompo, s2PlayerCompo;
    public AudioClip hoverButton, clickButton;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        /*
        mMenuComponents = GameObject.Find("Components").transform.gameObject;
        mMenuPanel = GameObject.Find("MainPanel").transform.gameObject;
        print("MIERDA");
        //settingsComponents = GameObject.Find("SettingsComponents").transform.gameObject;
        //creditsComponents = GameObject.Find("CreditsComponents").transform.gameObject;
        //surePanel = GameObject.Find("AreUSure").transform.gameObject;
        
        //selectorPanel = GameObject.Find("PanelS").transform.gameObject;
        sPlayersComponents = GameObject.Find("SPlayersComponents").transform.gameObject;

        s1PlayerCompo = GameObject.Find("SPJSolo").transform.gameObject;
        textSoloPlayer = GameObject.Find("Components").transform.gameObject;
        photoSoloPlayer = GameObject.Find("Components").transform.gameObject;

        s2PlayerCompo = GameObject.Find("SPJ2Players").transform.gameObject;
        textJ1 = GameObject.Find("Components").transform.gameObject;
        textJ2 = GameObject.Find("Components").transform.gameObject;
        photoJ1 = GameObject.Find("Components").transform.gameObject;
        photoJ2 = GameObject.Find("Components").transform.gameObject;

        LeanTween.moveLocalX(_slotsPanel, 550, 0.8f).setEaseInOutCubic().setOnComplete(ClosePanels);
        */
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HoverButton()
    {
        audioSource.clip = hoverButton;
        audioSource.Play();
    }

    public void Play()
    {
        SoundClickButton();
        mMenuComponents.SetActive(false);
        sPlayersComponents.SetActive(true);
        selectorPanel.SetActive(true);
    }

    public void BackPlay()
    {
        SoundClickButton();
        mMenuComponents.SetActive(true);
        sPlayersComponents.SetActive(false);
        selectorPanel.SetActive(false);
    }

    public void PlayWith1()
    {
        SoundClickButton();
        sPlayersComponents.SetActive(false);
        selectorPanel.SetActive(true);
        s1PlayerCompo.SetActive(true);

    }

    public void PlayWith2()
    {
        SoundClickButton();
        sPlayersComponents.SetActive(false);
        selectorPanel.SetActive(true);
        s2PlayerCompo.SetActive(true);
    }

    public void BackCharacter()
    {
        SoundClickButton();
        sPlayersComponents.SetActive(true);
        selectorPanel.SetActive(true);
        s1PlayerCompo.SetActive(false);
        s2PlayerCompo.SetActive(false);
    }

    public void Settings()
    {
        SoundClickButton();
        settingsComponents.SetActive(true);
        mMenuComponents.SetActive(false);
    }

    public void BackSettings()
    {
        SoundClickButton();
        settingsComponents.SetActive(false);
        mMenuComponents.SetActive(true);
    }

    public void Credits()
    {
        SoundClickButton();
        creditsComponents.SetActive(true);
        mMenuComponents.SetActive(false);
    }

    public void BackCredits()
    {
        SoundClickButton();
        creditsComponents.SetActive(false);
        mMenuComponents.SetActive(true);
    }

    public void Exit()
    {
        SoundClickButton();
        surePanel.SetActive(true);
    }

    public void ExitYes()
    {
        SoundClickButton();
        Application.Quit();
    }

    public void ExitNo()
    {
        SoundClickButton();
        surePanel.SetActive(false);
    }

    public void SoundClickButton()
    {
        audioSource.clip = clickButton;
        audioSource.Play();
    }

    public void BackToMenu()
    {
        SoundClickButton();
        SceneManager.LoadScene(0);
    }
}
