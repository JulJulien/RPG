using UnityEngine;
using System.Collections.Generic;

public class EnemyComponent : MonoBehaviour
{
    public string Name;
    public float MaxHealth;
    public float CurrentHealth;
    public List<AttackSO> AttackList_SO;
    public List<DamageTypeSO> Weaknesses_SO;
    public List<DamageTypeSO> Resistances_SO;

    public void OnSelect(){
    
    }

}