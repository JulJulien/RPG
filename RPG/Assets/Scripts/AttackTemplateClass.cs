using System.Collections;
using Unity.VisualScripting;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Attack
    {
        public string AttackName {get; set;}
        public string AttackDescription{get; set;}
        public int AttackDamage {get; set;}
        public string AttackType {get; set;}
        public string Condition {get; set;}
        public string CombatDescription {get; set;}
        public string Animation {get; set;}
        public int BaseDamage {get; set;}
        public int AdditionalDamage {get; set;}
        public int TotalDamage => BaseDamage + AdditionalDamage;
    }