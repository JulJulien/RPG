using System.Collections;
using Unity.VisualScripting;
using System.Collections.Generic;
using UnityEngine;
using System;

// This file contains every possible attack for every enemy in the game.
// To access these attacks use the usingAttackDatabaseNamespace
// then create an object called AttackDatabase attackDatabase = GetComponent<AttackDatabase>();
// and then access a specific attack with attackDatabase.AttackName
// When creating a list of attacks for an enemy use #region Enemy Name and #endregion to stay organized

namespace AttackDatabaseNamespace{
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

    public class AttackDatabase : MonoBehaviour
    {
        // Example attack
        public Attack Bite = new Attack
        {
                AttackName = "Bite",
                AttackDescription = "Bite your opponent and cause infection.",
                AttackDamage = 12,
                AttackType = "Physical",
                Condition = "Infection",
                CombatDescription = "bites you.",
                Animation = "Bite.gif",
                BaseDamage = 50,
                AdditionalDamage = 30
        };

        public Attack Fireball = new Attack
        {
            AttackName = "Fireball",
            AttackDescription = "Hurls a blazing fireball at your enemy, causing fire damage.",
            AttackDamage = 20,
            AttackType = "Magic",
            Condition = "Burn",
            CombatDescription = "launches a fireball.",
            Animation = "Fireball.gif",
            BaseDamage = 60,
            AdditionalDamage = 40
        };

        public Attack Slash = new Attack
        {
            AttackName = "Slash",
            AttackDescription = "A quick slash with a sharp weapon that may cause bleeding.",
            AttackDamage = 15,
            AttackType = "Physical",
            Condition = "Bleed",
            CombatDescription = "slashes with a sharp blade.",
            Animation = "Slash.gif",
            BaseDamage = 40,
            AdditionalDamage = 20
        };

        public Attack Thunderstrike = new Attack
        {
            AttackName = "Thunderstrike",
            AttackDescription = "Calls down lightning from the sky, shocking the opponent.",
            AttackDamage = 25,
            AttackType = "Magic",
            Condition = "Paralyze",
            CombatDescription = "summons a thunderstrike.",
            Animation = "Thunderstrike.gif",
            BaseDamage = 70,
            AdditionalDamage = 50
        };

        public Attack PoisonSpit = new Attack
        {
            AttackName = "Poison Spit",
            AttackDescription = "Spits venom at your enemy, inflicting poison damage over time.",
            AttackDamage = 10,
            AttackType = "Ranged",
            Condition = "Poison",
            CombatDescription = "spits poison.",
            Animation = "PoisonSpit.gif",
            BaseDamage = 30,
            AdditionalDamage = 15
        };

        public Attack Frostbite = new Attack
        {
            AttackName = "Frostbite",
            AttackDescription = "Freezes the opponent with a blast of cold, slowing them down.",
            AttackDamage = 18,
            AttackType = "Magic",
            Condition = "Frozen",
            CombatDescription = "engulfs you in freezing cold.",
            Animation = "Frostbite.gif",
            BaseDamage = 55,
            AdditionalDamage = 35
        };

        public Attack Earthquake = new Attack
        {
            AttackName = "Earthquake",
            AttackDescription = "Shakes the ground, causing massive physical damage to all enemies.",
            AttackDamage = 30,
            AttackType = "Physical",
            Condition = "Stun",
            CombatDescription = "causes a massive earthquake.",
            Animation = "Earthquake.gif",
            BaseDamage = 80,
            AdditionalDamage = 60
        };

        public Attack ShadowStrike = new Attack
        {
            AttackName = "Shadow Strike",
            AttackDescription = "Strikes from the shadows, dealing massive damage while going unnoticed.",
            AttackDamage = 22,
            AttackType = "Physical",
            Condition = "Blind",
            CombatDescription = "strikes from the shadows.",
            Animation = "ShadowStrike.gif",
            BaseDamage = 65,
            AdditionalDamage = 45
        };
    }   
}   

