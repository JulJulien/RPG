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
<<<<<<< HEAD
    public Transform EnemyStation;
=======
    public GameObject PanelEnemyPrefab;
>>>>>>> 4cd096b1c6ba2999fadeec7f0a9226cc712d3f15
    public GameObject EnemyPrefab;

    public BattleState currentState;

<<<<<<< HEAD
    void Start()
    {
        currentState = BattleState.START;
        SetState(currentState, EnemyPrefab);
    }

=======
    SetState = BattleState.START;

    void Start(){
        SetupBattle();
    }

    void SetupBattle(){
        Debug.Log("SetupBattle");
        Instantiate(EnemyPrefab, PanelEnemyPrefab);
    }
>>>>>>> 4cd096b1c6ba2999fadeec7f0a9226cc712d3f15
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
<<<<<<< HEAD
        SetupBattle();
        PartyTurn(Enemy);
    }
    // Start Combat

    void SetupBattle(){
        Debug.Log("Battle Start");
        Instantiate(EnemyPrefab, EnemyStation);
        Debug.Log("Enemy Spawned");
    }
    void PartyTurn(GameObject Enemy){
        
        Debug.Log("Players turn");
        SetState(BattleState.ENEMYTURN, Enemy);
    }

    void EnemyTurn(GameObject Enemy){
        Debug.Log("Enemy turn");

    }

    void EndBattle(GameObject Enemy){
        Debug.Log("Encounter End: You Loose");

    }

=======
    }
  
>>>>>>> 4cd096b1c6ba2999fadeec7f0a9226cc712d3f15
}
