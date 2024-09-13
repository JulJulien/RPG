using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BattleSystemNamespace;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
namespace CombatUINamespace{

public class CombatUI: MonoBehaviour{

    // Initialize UI components
    // Buttons in the array are in specified in the Canvas Inspector
    #region Declare UI Components

    public Text UITextbox;
    public Button[] partyMemberButtons;
    public Button[] attackButtons;
    public Button[] abilityButtons;

    public Button ChooseAttack;
    public Button ChooseAbility;
    public Button ChooseOther;
    public Button SelectedPartyMemberButton;
    public GameObject Panel_PartySelect;
    public GameObject Panel_PartyMemberChoices;
    public GameObject Panel_AttackAblitySelect;

    #endregion
    
    void Start(){
        #region Button Listeners

        ChooseAttack.onClick.AddListener(() => OnChooseAttackButtonClick());
        ChooseAbility.onClick.AddListener(() => OnChooseAbilityButtonClick());
        ChooseOther.onClick.AddListener(() => OnChooseOtherButtonClick());

        SelectedPartyMemberButton.onClick.AddListener(() => OnSelectedPartyMemberButtonClick());

        // When a party member button is clicked, call the OnPartyMemberButtonClick method
        foreach (Button btn in partyMemberButtons)
        {
            btn.onClick.AddListener(() => OnPartyMemberButtonClick(btn));
        }

        // When a party member button is clicked, call the OnAttackButtonClick method
        foreach (Button btn in attackButtons)
        {
            btn.onClick.AddListener(() => OnAttackButtonClick(btn));
        }

        // When a party member button is clicked, call the OnAbilityButtonClick method
        foreach (Button btn in abilityButtons)
        {
            btn.onClick.AddListener(() => OnAbilityButtonClick(btn));
        }
        #endregion
    }

    // Player selected a party member in Character list
    void OnPartyMemberButtonClick(Button clickedButton)
    {
        Debug.Log("Party Member Button Clicked: " + clickedButton.name);
        
        // Get the Image component from the clicked button (PartyMemberButton)
        Image selectedPartyMemberImage = clickedButton.GetComponent<Image>();
        
        if (selectedPartyMemberImage != null)
        {
            // Log the sprite name for debugging
            Debug.Log("Selected Party Member Image: " + selectedPartyMemberImage.sprite.name);
            
            // Get the Image component of the SelectedPartyMemberButton
            Image selectedButtonImage = SelectedPartyMemberButton.GetComponent<Image>();

            if (selectedButtonImage != null)
            {
                // Assign the clicked button's image to the SelectedPartyMemberButton's image
                selectedButtonImage.sprite = selectedPartyMemberImage.sprite;
                
                Debug.Log("Updated Selected Party Member Button with new image: " + selectedButtonImage.sprite.name);
            }
        }
        // Show and hide the relevant UI panels
        Panel_PartyMemberChoices.SetActive(true);
        Panel_PartySelect.SetActive(false);
        Panel_AttackAblitySelect.SetActive(false);
    }


    //Selected Character Portrait Button
    void OnSelectedPartyMemberButtonClick()
    {
        Debug.Log("Selected Party Member Button Clicked: ");
        Panel_PartySelect.SetActive(true);
        Panel_PartyMemberChoices.SetActive(false);
        Panel_AttackAblitySelect.SetActive(false);
        DeleteAbilityList();
        DeleteAttackList();
    }

    // Character selects Attack and Attacks are presented
    void OnChooseAttackButtonClick()
    {
        Debug.Log("Attack Button Clicked: ");
        Panel_PartySelect.SetActive(false);
        Panel_PartyMemberChoices.SetActive(true);
        Panel_AttackAblitySelect.SetActive(true);
        CreateAttackList();
        DeleteAbilityList();
    }

    // Character selects Abilities and Abilities are presented
    void OnChooseAbilityButtonClick()
    {
        Debug.Log("Ability Button Clicked: ");
        Panel_PartySelect.SetActive(false);
        Panel_PartyMemberChoices.SetActive(true);
        Panel_AttackAblitySelect.SetActive(true);
        CreateAbilityList();
        DeleteAttackList();
    }

    // Character selects Other and Other options are presented
    void OnChooseOtherButtonClick()
    {
        Debug.Log("Other Button Clicked: ");
        Panel_PartySelect.SetActive(false);
        Panel_PartyMemberChoices.SetActive(true);
        Panel_AttackAblitySelect.SetActive(true);
    }
    void OnAttackButtonClick(Button clickedButton)
    {
        Debug.Log("Attack Button Clicked: " + clickedButton.name);
        // Implement your logic here
    }

    void OnAbilityButtonClick(Button clickedButton)
    {
        Debug.Log("Ability Button Clicked: " + clickedButton.name);
        // Implement your logic here
    }

    void CreateAttackList(){
        // Activate all attack buttons, or define a specific range of buttons you want to display
        foreach (Button btn in attackButtons)
        {
            btn.gameObject.SetActive(true);
            Debug.Log("Activated Attack Button: " + btn.name);
        }
    }

    void CreateAbilityList(){
        // Activate all ability buttons, or define a specific range of buttons you want to display
        foreach (Button btn in abilityButtons)
        {
            btn.gameObject.SetActive(true);
            Debug.Log("Activated Ability Button: " + btn.name);
        }
    }
    void DeleteAttackList(){
        foreach (Button btn in attackButtons)
        {
            btn.gameObject.SetActive(false);

        }
    }
     void DeleteAbilityList(){
        foreach (Button btn in abilityButtons)
        {
            btn.gameObject.SetActive(false);
        }
    }
}
}