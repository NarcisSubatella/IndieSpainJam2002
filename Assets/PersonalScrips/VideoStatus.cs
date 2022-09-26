using MoreMountains.TopDownEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoStatus : MonoBehaviour
{
	public VideoPlayer vid;
	public GameObject videoHolder;
	private bool played = false;
	private bool played2 = false;

	private void Start() { 

		if (GameManager.current.skipIntroVideo)
        {
			videoHolder.SetActive(false);
			SoundSystem.current.PlayeClip(1,1);
			SoundSystem.current.StopPlaing(0);
			Time.timeScale = 1;
		}
		else
        {
			videoHolder.SetActive(true);
			SoundSystem.current.PlayeClip(3,0);
			SoundSystem.current.PlayeClip(2, 1);
			Time.timeScale = 0;
        }

		vid.loopPointReached += CheckOver;

	}


	void CheckOver(UnityEngine.Video.VideoPlayer vp)
	{
				Invoke("DeleteAll", 3);
	}


	private void LateUpdate()
    {
        if(!GameManager.current.skipIntroVideo)
        {

			if (vid.frame >= 370 && !played)
			{
				played = true;;
				SoundSystem.current.PlayeClip(0, 0);
				SoundSystem.current.StopPlaing(1);

			}
			if (vid.frame >= 480 && !played2)
			{
				played2 = true;
				SoundSystem.current.PlayeClip(1, 1);
				StartCoroutine(ChangeAudi());
				Time.timeScale = 1;
			}
        }
    }

    private void DeleteAll()
    {
		GameManager.current.StartDestroing();

		Destroy(videoHolder);
		Destroy(this.gameObject);
	}
	private IEnumerator ChangeAudi()
    {
		yield return new WaitForSeconds(4);
	   videoHolder.GetComponent<Animator>().SetTrigger("AnimOn");

	}
}