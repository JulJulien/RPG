using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using AttackDatabaseNamespace; // Ensure you're using the correct namespace

public class EnemyBaseClass : MonoBehaviour
{
    public string EnemyName; 
    public AttackDatabase attackDatabase; // Reference to the AttackDatabase component
    public Dictionary<string, Dictionary<string, object>> EnemyComponents; // Enemy components (as a dictionary)

    public void Start()
    {
        // Initialize EnemyComponents
        EnemyComponents = new Dictionary<string, Dictionary<string, object>>();
    }
}
