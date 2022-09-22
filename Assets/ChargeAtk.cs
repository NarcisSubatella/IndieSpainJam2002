using MoreMountains.Feedbacks;
using MoreMountains.TopDownEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargeAtk : MonoBehaviour
{
    private void Start()
    {
        /* Character player = GetComponentInParent<Character>();

          GetComponent<MeleeWeapon>().Animators[0] = player.CharacterAnimator;*/
        Character player = GetComponentInParent<Character>();

        GetComponent<MMFeedbackAnimation>().BoundAnimator = player.CharacterAnimator;
    }
    
}
