using MoreMountains.TopDownEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControl : MonoBehaviour
{
public void ControlAnim()
    {
        GetComponentInParent<CharacterHandleSecondaryWeapon>().enabled = true;
    }
}
