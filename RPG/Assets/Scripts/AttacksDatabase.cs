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

public class AttackDatabase : MonoBehaviour{
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
}   




