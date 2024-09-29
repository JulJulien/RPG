using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;
public class PlayerController : MonoBehaviour
{
    private bool select;
    private bool pause;
    private bool sprint;
    public bool canMove = true;
    public float moveSpeed = 5f;
    public float sprintSpeedMultiplier =2f;


    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Check for Select and Pause input
        select = Input.GetKeyDown(KeyCode.Space);
        pause = Input.GetKeyDown(KeyCode.Escape);
        sprint = Input.GetKey(KeyCode.LeftShift);
        //Debug.Log("Player Update");

            // Automatically configures WASD and arrow keys to x and y axis movement
            Vector2 playerInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
            //Debug.Log("Player Input: " + playerInput);

            // Apply sprint multiplier if sprinting
            float currentSpeed = sprint ? moveSpeed * sprintSpeedMultiplier : moveSpeed;
            //Debug.Log("Current Speed: " + currentSpeed);

            // Move the player
            transform.position += (Vector3)playerInput * currentSpeed * Time.deltaTime;
            //Debug.Log("Player Position Before: " + transform.position);
    }
}