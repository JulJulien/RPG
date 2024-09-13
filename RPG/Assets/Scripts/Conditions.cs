using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using AttackDatabaseNamespace;

public class Conditions : MonoBehaviour 
{
    public void apply_condition(string condition){
        switch(condition){
            case "Paralyze":
                Infection();
                break;
            case "Disarmed":
                Bleeding();
                break;
            case "Poison":
                Poison();
                break;
            case "Stun":
                Stun();
                break;
            case "Burn":
                Burn();
                break;
            default:
                break;
        } 
    }

    public void Infection()
    {
        // Add code for infection
    }

    public void Bleeding()
    {
        // Add code for bleeding
    }

    public void Poison()
    {
        // Add code for poison
        // Take physical damage over 3 turns
    }

    public void Stun()
    {
        // Add code for stun
        // Skip a turn
    }

    public void Burn()
    {
        // Add code for burn
        // Take magic damage over 3 turns
    }

    public void Paralyze()
    {
        // Add code for paralyze
        // Cannot perform any action until the end of the battle
    }


}