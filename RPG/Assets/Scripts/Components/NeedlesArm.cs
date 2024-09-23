using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeedlesArm : EnemyComponent
{
    // Start is called before the first frame update
    void Start()
    {
        Name = "Needles Arm";
        MaxHealth = 100;
        CurrentHealth = MaxHealth;
        attackList = new List<AttackSO>();
        Weaknesses = new List<DamageTypeSO>();
        Resistances = new List<DamageTypeSO>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
