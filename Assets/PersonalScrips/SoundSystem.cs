using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSystem : MonoBehaviour
{
    public static SoundSystem current;

    [SerializeField] private AudioClip[] music;
    [SerializeField] private AudioSource[] sources;

    private void Start()
    {
        current = this;
    }
    public void PlayeClip(int pos,int source)
    {
        sources[source].clip = music[pos];
        sources[source].Play();
    }
    public void StopPlaing(int source)
    {
        sources[source].Stop();
    }
}
