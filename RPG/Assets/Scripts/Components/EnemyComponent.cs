using UnityEngine;
using System.Collections.Generic;

public class EnemyComponent : MonoBehaviour
{
    public string Name;
    public float MaxHealth;
    public float CurrentHealth;
    public List<AttackSO> attackList;
    public List<DamageTypeSO> Weaknesses;
    public List<DamageTypeSO> Resistances;
}