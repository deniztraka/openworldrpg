﻿using System;
using System.Collections;
using DTWorld.Core.Mobiles;
using DTWorld.Interfaces;
using UnityEngine;

namespace DTWorld.Core.Items.Weapons
{
    public abstract class BaseWeapon : BaseItem, IWeapon
    {
        private IAttackType attackType;
        private BaseMobile mobile;
        private float damage;
        private float swingSpeed;
        public float SwingSpeed
        {
            get { return swingSpeed; }
            set { swingSpeed = value; }
        }
        public float Damage
        {
            get { return damage; }
            set { damage = value; }
        }
        public IAttackType AttackType
        {
            get { return attackType; }
            set { attackType = value; }
        }

        public BaseMobile Mobile
        {
            get { return mobile; }
            set { mobile = value; }
        }

        public BaseWeapon(string name) : base(name)
        {
        }

        public BaseWeapon(string name, BaseMobile mobile) : base(name)
        {
            this.mobile = mobile;
        }

        public virtual void Hit(BaseMobile mobile)
        {
            Mobile.TakeDamage(damage);
            //Debug.Log("attacked from baseWeapon");
        }
    }
}
