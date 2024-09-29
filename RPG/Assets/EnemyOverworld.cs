using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyOverworld : MonoBehaviour
{
    // Reference to the enemy prefab
    public GameObject EnemyPrefab;

    // This is a reference to the BattleSystem in the scene
    public BattleSystem battleSystem;

    private void Start()
    {
        // Find the BattleSystem in the scene
        battleSystem = FindObjectOfType<BattleSystem>();
    }

    // Trigger detection for 2D collision
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the collider belongs to the player
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player has entered an enemy's trigger");

            // Load the combat UI scene (if needed)
            SceneManager.LoadScene("CombatUI", LoadSceneMode.Single);
            
        }
    }

}
