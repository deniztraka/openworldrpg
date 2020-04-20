﻿using DTWorld.Behaviours.Items.Weapons;
using DTWorld.Behaviours.Mobiles.Human;
using DTWorld.Core.Mobiles;
using DTWorld.Engines.Movement;
using UnityEngine;

namespace DTWorld.Behaviours.Mobiles
{
    public class PlayerBehaviour : HumanBehaviour
    {

        public override void Start()
        {
            base.Start();

            this.Mobile = new Player(this.Speed, new FreeFormMovement(this.Rigidbody2D));

            // add weapon object in the handle
            if (RightHandle != null)
            {
                var weaponBehaviour = RightHandle.GetComponentInChildren<BaseWeaponBehaviour>();
                if (weaponBehaviour != null)
                {
                    AddWeapon(weaponBehaviour);
                }
            }
        }

        public void Update()
        {

            if (Input.GetKeyDown(KeyCode.Space) && CanAttack())//if mobile can attack / timing is okey?
            {
                //attack with weapon if mobile has any weapon      
                if (RightHandle != null && RightHandle.transform.childCount > 0)
                {
                    if (WeaponBehaviour == null)
                    {
                        WeaponBehaviour = RightHandle.GetComponentInChildren<BaseWeaponBehaviour>();
                        if (WeaponBehaviour != null)
                        {
                            WeaponBehaviour.Attack();
                        }
                    } else {
                        WeaponBehaviour.Attack();
                    }
                }
            }
        }

        public override void FixedUpdate()
        {
            base.FixedUpdate();
        }
    }
}