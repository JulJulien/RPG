using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyBaseClass : MonoBehaviour
{
    public string EnemyName; 
    public GameObject AttackDatabase; // Reference to the AttackDatabase component
    public Dictionary<string, Dictionary<string, object>> EnemyComponents; // Enemy components (as a dictionary)

    public GameObject EnemyPrefab;
    public void Start()
    {
        // Initialize EnemyComponents
        EnemyComponents = new Dictionary<string, Dictionary<string, object>>();
    }
}
