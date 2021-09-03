using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace BerserkAdventure
{
    public class Berserk : MonoBehaviour, ISetHp
    {
		[SerializeField] private float _hp = 90;
		private bool _isDeath = false;

		Animator _animator;

		public float Hp
		{
			get { return _hp; }
			private set { _hp = value; }
		}

		public void SetHp(InfoOfCollision info)
		{
			if (Hp > 0)
			{
				//Hp -= info.Damage;
				Hp -= Random.Range(10, 20);
			}

			if (Hp <= 0)
			{
				_isDeath = true;
				_animator.Play("Death");
			}
			Debug.Log("_hp  - " + Hp);
		}
	}
}