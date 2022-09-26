using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSystem : MonoBehaviour
{

    [SerializeField] private AudioClip[] music;
    [SerializeField] private AudioSource[] sources;
    

    public void PlayeClip(int pos,int source)
    {
        sources[source].clip = music[pos];
    }
}
