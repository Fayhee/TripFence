using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputMap : MonoBehaviour
{
    
    public bool useOldInputSystem;

   
    float currentTime;

    PlayerControls playerControls;

    private void Awake()
    {
        playerControls = new PlayerControls();
    }

    private void OnEnable()
    {
        playerControls.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }

    private void Update()
    {
        if (useOldInputSystem) OldInputSystem();
        else NewInputSystem();
    }

    void OldInputSystem()
    {
        currentTime += Time.deltaTime;
        if (Input.GetKey(KeyCode.Space))
        {

        }
    }

    void NewInputSystem()
    {
        currentTime += Time.deltaTime;
        bool isSpaceKeyHeld = playerControls.Player.SpaceKey.ReadValue<float>() > 0.1f;
        if (isSpaceKeyHeld)
        {
            Debug.Log("I am a LoveSon");
        }
    }

}
