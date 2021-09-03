using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace BerserkAdventure
{
	public class Bow : BaseWeapon
	{
		private void Start()
		{
			Ammunition = UnityEngine.Resources.Load<Arrow>("Arrow");
			//for (var i = 0; i <= 5; i++)
			//{
			//	AddClip(new Clip { CountAmmunition = 2000 });
			//}

			//ReloadClip();
		}
		public override void Fire()
		{
			Invoke("ArrowInst", 0.9f);
		}

		private void ArrowInst()
		{
			if (!_isReady) return;
			//if (Clip.CountAmmunition <= 0) return;
			if (Ammunition)
			{
				var temAmmunition = Instantiate(Ammunition, _barrel.position, _barrel.rotation);// Pool object
				temAmmunition.AddForce(_barrel.forward * _force);
				//Clip.CountAmmunition--;
				_isReady = false;
				Invoke(nameof(ReadyShoot), _rechergeTime);
				//_timer.Start(_rechergeTime);
			}
		}
	}
}