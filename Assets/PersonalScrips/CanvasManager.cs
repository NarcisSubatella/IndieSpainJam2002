using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using MoreMountains.TopDownEngine;
using UnityEngine.SceneManagement;

public class CanvasManager : MonoBehaviour
{
    [SerializeField] private Slider wrahtSlider;
    [SerializeField] private TextMeshProUGUI wrathTxt;
    [SerializeField] private Health playeHealth;
    [SerializeField] private Image characterSpriteHolder;

    public GameObject mMenuComponents, mMenuPanel, settingsComponents, creditsComponents, surePanel, selectorPanel, sPlayersComponents, pauseMenu;
    public AudioClip hoverButton, clickButton;
    public AudioSource audioSource;


    private int wrathInt;
    private void Start()
    {
        wrahtSlider.maxValue = playeHealth.InitialHealth; 
        wrahtSlider.value = playeHealth.InitialHealth;
        characterSpriteHolder.sprite = GameManager.current.charactersInfo[PlayerPrefs.GetInt("PJ1")].characterImg;
    }
    private void LateUpdate()
    {
        wrathInt = (int)playeHealth.CurrentHealth;

       wrahtSlider.value = playeHealth.CurrentHealth;
        wrathTxt.text = wrathInt.ToString()+"%";
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 0;
        }

    }
    public void RestoreTime()
    {
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
    }
    public void RestarScena()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

}
