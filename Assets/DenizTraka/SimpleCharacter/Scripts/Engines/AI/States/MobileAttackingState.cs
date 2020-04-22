﻿using System.Collections;
using System.Collections.Generic;
using DTWorld.Behaviours.Mobiles;
using UnityEngine;
namespace DTWorld.Engines.AI.States
{
    public class MobileAttackingState : MobileIdleState
    {
        BaseMobileBehaviour target;
        public MobileAttackingState(BaseMobileBehaviour mobile, BaseMobileBehaviour target, bool isAggressive, float chaseDistance) : base(mobile, isAggressive, chaseDistance)
        {
            this.target = target;
        }

        public override float GetXAxis()
        {
            return 0f;
        }

        public override float GetYAxis()
        {
            return 0f;
        }

        public override void OnStateExit()
        {

        }

        public override BaseMobileState OnStateUpdate()
        {
            MobileBehaviour.Attack();

            var baseResult = base.OnStateUpdate();
            if (baseResult != null)
            {
                
                return baseResult;
            }

            return null;
        }

        internal override void OnStateFixedUpdate()
        {

        }
    }
}