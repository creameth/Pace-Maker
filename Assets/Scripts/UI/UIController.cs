using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public GameObject pauseMenuPanel;
    public GameObject settingsPanel;
    public GameObject mainMenuButtons;
    public GameObject magicOrb;
    private MouseMovement _mouseMovementScript;


    void Start()
    {
        // Get references to the buttons and add click listeners

        _mouseMovementScript = magicOrb.GetComponent<MouseMovement>();
        // Hide the pause menu at the start of the game
        pauseMenuPanel.SetActive(false);
        settingsPanel.SetActive(false);
    }

    void Update()
    {
        // Check for the Escape key to be pressed
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // If the pause menu is not active, show it and pause the game
            if (!pauseMenuPanel.activeSelf)
            {
                pauseMenuPanel.SetActive(true);
                mainMenuButtons.SetActive(true);
                _mouseMovementScript.enabled = false;
                
                
                Time.timeScale = 0;
            }
            // If the pause menu is active, hide it and resume the game
            else
            {
                CloseMenu();
                Time.timeScale = 1;
               
            }
        }
    }

    public void ResumeGame()
    {
        CloseMenu();
        Time.timeScale = 1;
    }
    

    public void ExitGame()
    {
        Application.Quit();
    }

    public void CloseMenu()
    {
        pauseMenuPanel.SetActive(false);
        settingsPanel.SetActive(false);
        _mouseMovementScript.enabled = true;
            
    }
            
    
}
