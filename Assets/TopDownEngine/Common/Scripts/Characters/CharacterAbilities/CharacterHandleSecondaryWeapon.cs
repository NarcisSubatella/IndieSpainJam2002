using UnityEngine;
using System.Collections;
using MoreMountains.Tools;

namespace MoreMountains.TopDownEngine
{
	/// <summary>
	/// Add this class to a character so it can use weapons
	/// Note that this component will trigger animations (if their parameter is present in the Animator), based on 
	/// the current weapon's Animations
	/// Animator parameters : defined from the Weapon's inspector
	/// </summary>
	[AddComponentMenu("TopDown Engine/Character/Abilities/Character Handle Secondary Weapon")]
	public class CharacterHandleSecondaryWeapon : CharacterHandleWeapon
	{
		/// the ID / index of this CharacterHandleWeapon. This will be used to determine what handle weapon ability should equip a weapon.
		/// If you create more Handle Weapon abilities, make sure to override and increment this  
		public override int HandleWeaponID { get { return 2; } }

		/// <summary>
		/// Gets input and triggers methods based on what's been pressed
		/// </summary>
		public float getForce = 0;
		public int maxMultiplicator=3;
		//public Animator pjAnim;


        private void Activator(bool activator)
        {
			GetComponentInParent<CharacterMovement>().InputAuthorized = activator;
			//GetComponentInParent<Character>().enabled = activator;
			GetComponentInParent<CharacterHandleWeapon>().AbilityPermitted = activator;
			//pjAnim = GetComponentInParent<Animator>();
		}
		protected override void HandleInput()
		{
			if (!AbilityAuthorized
			    || (_condition.CurrentState != CharacterStates.CharacterConditions.Normal))
			{
				return;
			}
			if ((_inputManager.SecondaryShootButton.State.CurrentState == MMInput.ButtonStates.ButtonPressed) || (_inputManager.SecondaryShootAxis == MMInput.ButtonStates.ButtonPressed))
			{
				if(CurrentWeapon != null)
				{
					if(getForce<maxMultiplicator)
                    {
						getForce += Time.deltaTime;
						Activator(false);
						//GetComponentInParent<Animator>().SetBool("SupAtk", true);
                    }

				}
			}
			
			/*if (CurrentWeapon != null)
			{
				bool buttonPressed =
					(_inputManager.SecondaryShootButton.State.CurrentState == MMInput.ButtonStates.ButtonPressed) ||
					(_inputManager.SecondaryShootAxis == MMInput.ButtonStates.ButtonPressed); 
                
				if (ContinuousPress && (CurrentWeapon.TriggerMode == Weapon.TriggerModes.Auto) && buttonPressed)
				{
					ShootStart();
				}
			}*/

			if (_inputManager.ReloadButton.State.CurrentState == MMInput.ButtonStates.ButtonDown)
			{
				Reload();
			}

			//si se suelta el boton, a�ade da�o y ataca
			if ((_inputManager.SecondaryShootButton.State.CurrentState == MMInput.ButtonStates.ButtonUp) || (_inputManager.SecondaryShootAxis == MMInput.ButtonStates.ButtonUp))
			{
				if (CurrentWeapon != null)
                {

					minD = CurrentWeapon.GetComponent<MeleeWeapon>().MinDamageCaused;
				    maxD = CurrentWeapon.GetComponent<MeleeWeapon>().MaxDamageCaused;

					if(minD < getForce && maxD < getForce)
                    {
						CurrentWeapon.GetComponent<MeleeWeapon>().ChangeDamageValue((int)getForce);
						GameManager.current.ConsumeWrath(0,true,(int)getForce);
					}
						ShootStart();
						Invoke("RestoreD", 1);	
						getForce = 0;

					Activator(true);
				}


				//ShootStop();
			}

			if (CurrentWeapon != null)
			{
				if ((CurrentWeapon.WeaponState.CurrentState == Weapon.WeaponStates.WeaponDelayBetweenUses)
				    && ((_inputManager.SecondaryShootAxis == MMInput.ButtonStates.Off) && (_inputManager.SecondaryShootButton.State.CurrentState == MMInput.ButtonStates.Off))
				    && !(UseSecondaryAxisThresholdToShoot && (_inputManager.SecondaryMovement.magnitude > _inputManager.Threshold.magnitude)))
				{
					CurrentWeapon.WeaponInputStop();
				}
			}

			if (UseSecondaryAxisThresholdToShoot && (_inputManager.SecondaryMovement.magnitude > _inputManager.Threshold.magnitude))
			{
				ShootStart();
			}
		}
		int minD;
		int maxD;
		private void RestoreD()
        {
			CurrentWeapon.GetComponent<MeleeWeapon>().RestoreDamageValue(minD, maxD);
		}
	}

}