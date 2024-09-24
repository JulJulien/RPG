using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// This file controls the turn based combat for every enemy in the game.
// This battle system is dynamic such that every enemy encounter can be controlled by this script.
// The system is organized into 4 states: START, PARTYTURN, ENEMYTURN, WON, LOST
// These states are called by a Switch statemenet and their respective function.
// Within these functions are smaller functions that control the flow of combat and call the next state.

public enum BattleState{START, PARTYTURN, ENEMYTURN, WON, LOST}

public class BattleSystem : MonoBehaviour
{
    public GameObject PanelEnemyPrefab;
    public GameObject EnemyPrefab;

    public BattleState currentState;

    SetState = BattleState.START;

    void Start(){
        SetupBattle();
    }

    void SetupBattle(){
        Debug.Log("SetupBattle");
        Instantiate(EnemyPrefab, PanelEnemyPrefab);
    }
    public void SetState(BattleState currentState, GameObject Enemy)
    {
        EnemyPrefab = Enemy;
        Debug.Log("StateSet");
        switch (currentState)
        {
            case BattleState.START:
                Debug.Log("BattleState.START");
                StartCombat(Enemy);
                break;
            case BattleState.PARTYTURN:
                break;
            case BattleState.ENEMYTURN:
                break;
            case BattleState.WON:
                break;
            case BattleState.LOST:
                break;
        }
    }

    void StartCombat(GameObject Enemy){
        Debug.Log("Battle Start");
    }
  
}
