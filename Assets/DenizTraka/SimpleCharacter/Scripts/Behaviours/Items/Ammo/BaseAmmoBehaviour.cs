﻿using System.Collections;
using System.Collections.Generic;
using DTWorld.Behaviours.Audio;
using DTWorld.Behaviours.Interfacelike;
using DTWorld.Behaviours.Items.Weapons;
using DTWorld.Behaviours.Mobiles;
using DTWorld.Core.Items.Ammo;
using UnityEngine;
namespace DTWorld.Behaviours.Items.Ammo
{
    public class BaseAmmoBehaviour : BaseItemBehaviour
    {
        public BaseWeaponBehaviour OwnerWeaponBehaviour;

        private AudioManager audioManager;
        public new BaseAmmo Item;

        public override void Start()
        {
            base.Start();

            audioManager = gameObject.GetComponent<AudioManager>();
        }

        public override void Update()
        {
            base.Update();
        }

        void OnTriggerEnter2D(Collider2D other)
        {
            //preventing from getting damage from owner
            if (OwnerWeaponBehaviour.OwnerMobileBehaviour != null && other.gameObject.GetInstanceID() == OwnerWeaponBehaviour.OwnerMobileBehaviour.gameObject.GetInstanceID())
            {
                return;
            }

            Hit(other.GetComponent<HealthBehaviour>());
        }

        private void Hit(HealthBehaviour otherEntityHealth)
        {
            if (otherEntityHealth != null)
            {
                if (otherEntityHealth.Health > 0)
                {
                    otherEntityHealth.TakeDamage(OwnerWeaponBehaviour.Damage + Item.Damage);
                }
            }

            if (audioManager != null)
            {
                //Debug.Log("Hit");
                audioManager.Play("Hit");
            }

            StartCoroutine(DeactivateAfter(0.1f));
        }

        private IEnumerator DeactivateAfter(float seconds)
        {

            yield return new WaitForSeconds(seconds);
            gameObject.SetActive(false);
        }
    }
}