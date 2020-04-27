﻿using System.Collections;
using System.Collections.Generic;
using DTWorld.Core.Mobiles;
using UnityEngine;
namespace DTWorld.Core.Items.Weapons.Melee
{
    public class BaseMeleeWeapon : BaseWeapon
    {
        public BaseMeleeWeapon(string name) : base(name)
        {
            this.SwingSpeed = 1f;
        }
        public BaseMeleeWeapon(string name, float damage, float swingSpeed) : base(name, damage, swingSpeed)
        {
        }
        public BaseMeleeWeapon(string name, float damage, float swingSpeed, BaseMobile mobile) : base(name, damage, swingSpeed, mobile)
        {
        }
    }
}