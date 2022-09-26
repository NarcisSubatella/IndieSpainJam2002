using MoreMountains.TopDownEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoStatus : MonoBehaviour
{
	public VideoPlayer vid;
	public GameObject videoHolder;


	void Start() { vid.loopPointReached += CheckOver; }

	
	void CheckOver(UnityEngine.Video.VideoPlayer vp)
	{
		print("Video Is Over");
		GameManager.current.StartDestroing();

		Destroy(videoHolder);
		Destroy(this.gameObject);
	}

	private void AudioChange()
    {

    }
	private IEnumerator ChangeAudi()
    {
		yield return new WaitForSeconds(1);
    }
}