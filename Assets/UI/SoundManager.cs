using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;


public class SoundManager : MonoBehaviour
{
    [SerializeField] Slider mSlider, sSlider;
    [SerializeField] AudioMixer mixer;
    /*
    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 1);
            LoadMusicVol();
        }
        else
        {
            LoadMusicVol();
        }

        if (!PlayerPrefs.HasKey("soundsVolume"))
        {
            PlayerPrefs.SetFloat("soundsVolume", 1);
            LoadSoundsVol();
        }
        else
        {
            LoadSoundsVol();
        }
    }

    //EN ESTOS METODOS HACER EL CAMBIO DE SONIDO
    public void ChangeMusicVol()
    {
        AudioListener.volume = mSlider.value;
        SaveMusicVol();
    }

    public void ChangeMusicVol()
    {
        AudioListener.volume = mSlider.value;
        SaveSoundsVol();
    }

    private void LoadMusicVol()
    {
        mSlider.value = PlayerPrefs.GetFloat("musicVolume");
    }

    private void SaveMusicVol()
    {
        PlayerPrefs.SetFloat("musicVolume", mSlider.value);
    }

    private void LoadSoundsVol()
    {
        sSlider.value = PlayerPrefs.GetFloat("soundsVolume");
    }

    private void SaveSoundsVol()
    {
        PlayerPrefs.SetFloat("soundsVolume", sSlider.value);
    }*/
}
