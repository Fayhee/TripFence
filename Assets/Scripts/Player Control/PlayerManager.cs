using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    CameraManager cameraManager;
    InputManager inputManager;
    PlayerLocomotion playerLocomotion;

    private void Awake()
    {
        inputManager = GetComponent<InputManager>();
        playerLocomotion = GetComponent<PlayerLocomotion>();
        cameraManager = FindObjectOfType<CameraManager>();
    }

    private void Update()
    {
        inputManager.HandleMovementInput();
    }

    private void FixedUpdate()
    {
        playerLocomotion.HandleAllMovements();
    }

    private void LateUpdate(){
        cameraManager.HandleAllCameraMovements();
    }
}
