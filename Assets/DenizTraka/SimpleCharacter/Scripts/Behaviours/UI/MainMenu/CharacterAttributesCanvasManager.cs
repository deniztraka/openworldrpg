﻿using System.Collections;
using System.Collections.Generic;
using DTWorld.Behaviours.AI;
using DTWorld.Behaviours.Interfacelike;
using DTWorld.Behaviours.Mobiles;
using UnityEngine;
using UnityEngine.UI;

namespace DTWorld.Behaviours.UI.CharacterSelectionMenu
{

    public class CharacterAttributesCanvasManager : MonoBehaviour
    {
        public Text StrengthValue;
        public Text DexterityValue;
        public Text MeleeValue;
        public Text RangedValue;
        public MenuCharacterBehaviour menuCharacterBehaviour;
        private PropsBehaviour PropsBehaviour;
        public CharacterBookBehaviour BookBehaviour;

        public void Start()
        {
            menuCharacterBehaviour = GameObject.FindGameObjectWithTag("Player").GetComponent<MenuCharacterBehaviour>();
            PropsBehaviour = menuCharacterBehaviour.GetComponent<PropsBehaviour>();
            StrengthValue.text = PropsBehaviour.Strength.CurrentValue.ToString();
            DexterityValue.text = PropsBehaviour.Dexterity.CurrentValue.ToString();
            MeleeValue.text = PropsBehaviour.Melee.CurrentValue.ToString();
            RangedValue.text = PropsBehaviour.Ranged.CurrentValue.ToString();
        }
        public void CloseBook()
        {
            BookBehaviour.SetIsOpen(false);
            gameObject.SetActive(false);
        }
    }
}