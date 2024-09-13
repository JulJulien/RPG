using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMenu : MonoBehaviour
{
    public GameObject Selection_Raw_Menu;
    public GameObject Selected_Actions_Menu;

     // Method to open the options menu and close the main menu
    public void OpenOptionsMenu()
    {
        Selection_Raw_Menu.SetActive(false);   // Hide the main menu
        Selected_Actions_Menu.SetActive(true); // Show the options menu
    }

    // Method to go back to the main menu
    public void OpenMainMenu()
    {
        Selection_Raw_Menu.SetActive(false); // Hide the options menu
        Selected_Actions_Menu.SetActive(true);     // Show the main menu
    }
}
