using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public string Name;
    public int EnemyConsequtiveTurns;
    public int MaxPartyConsequtiveTurns;
    public List<EnemyComponent> Components;
    public List<EnemyComponent> InactiveComponents;
    public List<AttackSO> AvailableAttacks;

    public void GetAllAttacks(){       
        foreach(var component in Components){
            Debug.Log("$component");
            
            foreach (var attack in component.AttackList_SO){
                Debug.Log("$attack");
                AvailableAttacks.Add(attack);
            }
        }
    }

    public void RemoveAttack(AttackSO attack){
        AvailableAttacks.Remove(attack);
    }

    void start(){
        GetAllAttacks();
    }
}
