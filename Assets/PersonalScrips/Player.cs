using MoreMountains.TopDownEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace MoreMountains.TopDownEngine
{

public class Player : MonoBehaviour
{
    public bool grabingObject = false;
    public GameObject objectGrabed;
    public Transform topPos;
    public Transform sidePos;
    public Vector2 directionThrow;
    private CharacterOrientation2D orientation;
    private Character character;
    private void Awake()
    {
        orientation = GetComponent<CharacterOrientation2D>();
            character = GetComponent<Character>();
    }
    public void direction()
    {
        switch (orientation.CurrentFacingDirection)
        {
            case Character.FacingDirections.East:
                //sidePos.localRotation = new Quaternion(0, 0, 0, 0);
                directionThrow = Vector2.right;
                break;
            case Character.FacingDirections.North:
                // sidePos.localRotation = new Quaternion(0, 0, 90, 0);
                directionThrow = Vector2.up;
                break;
            case Character.FacingDirections.West:
                //  sidePos.localPosition = Vector2.left;
                directionThrow = Vector2.left;
                break;
            case Character.FacingDirections.South:
                // sidePos.localPosition = Vector2.down;
                directionThrow = Vector2.down;
                break;
        }

    }
    private void LateUpdate()
    {
        direction();
        if (Input.GetButton("Player1_Interact"))
        {
            if(character.objectGraping != null && character.objectGraping.GetComponent<PickableItem>().redyThrow==true && GetComponent<CharacterHandleWeapon>().CurrentWeapon!=null)
            {
                    // GetComponent<CharacterHandleWeapon>().CurrentWeapon = null;
                    //GetComponentInParent<Character>().objectGraping.SetActive(true);
                   /* if (GetComponent<CharacterHandleSecondaryWeapon>().CurrentWeapon !=null)
                    {
                        GetComponent<CharacterHandleSecondaryWeapon>().CurrentWeapon.gameObject.GetComponent<Weapon>().DirectDestructionWeapon();

                    }*/

                    GetComponent<CharacterHandleWeapon>().CurrentWeapon.gameObject.GetComponent<Weapon>().DirectDestructionWeapon();
                    GetComponent<Character>().objectGraping.GetComponent<ThrowItem>().ThrowObject();
                    GameManager.current.ConsumeWrath(0, false, 0);
            }
        }
    }
        private void DropItem()
        {
            objectGrabed.SetActive(true);
            objectGrabed.GetComponent<Collider2D>().enabled = true;
            objectGrabed.transform.SetParent(null);

        }
    }
}
