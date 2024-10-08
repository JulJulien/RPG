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
    public GameObject Panel_EnemyPrefab;
    public GameObject EnemyPrefab;
    public Text Text;

    public BattleState currentState;

<<<<<<< HEAD

    void Start(){
        SetupBattle();
    }

    void SetupBattle(){
        Debug.Log("SetupBattle");
    }
=======
>>>>>>> parent of 4cd096b (Enemy Prefab Made)
    public void SetState(BattleState currentState, GameObject Enemy)
    {
        Debug.Log("StateSet");
        switch (currentState)
        {
            case BattleState.START:
                Debug.Log("BattleState.START");
                StartCombat(Enemy);
                break;
            case BattleState.PARTYTURN:
                PartyTurn(Enemy);
                break;
            case BattleState.ENEMYTURN:
                EnemyTurn(Enemy);
                break;
            case BattleState.WON:
            case BattleState.LOST:
                //EndBattle(Enemy);
                break;
        }
    }

    void StartCombat(GameObject Enemy){
        Debug.Log("Battle Start");
        PauseOverworld();
        InitializeCombat();
        PartyTurn(Enemy);
    }
    // Start Combat
    #region 
    void PauseOverworld(){
        Time.timeScale = 0;
    }
    public void UnpauseOverwolrd(){
        Time.timeScale = 1;
    }
    void InitializeCombat(){
    }
        
    #endregion

    void PartyTurn(GameObject Enemy){
        
        Debug.Log("Players turn");
        SetState(BattleState.ENEMYTURN, Enemy);
    }

    void EnemyTurn(GameObject Enemy){
        Debug.Log("Enemy turn");
        
        if(CheckIfGameOver()){
            EndBattle(Enemy);
        }
        else{
            SetState(BattleState.PARTYTURN, Enemy);;
        }
    }

    void EndBattle(GameObject Enemy){
        Debug.Log("Encounter End: You Loose");
        UnpauseOverwolrd();

    }

     bool CheckIfGameOver(){
        return true;
    }
}
