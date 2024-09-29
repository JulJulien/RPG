using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AttackSO", menuName = "Scriptable Objects/AttackSO", order = 3)]
public class AttackSO : ScriptableObject
{
    public string attackName;
    public string damageType;
    public float baseDamage;
    public float additionalDamage;
    public string attackDescription;
    public ConditionSO attackCondition;

}
