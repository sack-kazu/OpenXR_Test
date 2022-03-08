using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class XRPlayerTest : MonoBehaviour
{
    [SerializeField] GameObject menuObj;
    PlayerInput _input;
    void Awake()
    {
        TryGetComponent(out _input);
        menuObj.SetActive(false);
    }
    void OnEnable()
    {
        var normal = _input.actions.FindActionMap("XRI RightHand");
        var menuMode = _input.actions.FindActionMap("XRI RightHand Menu");
        normal["PrimaryButton"].started += OpenMenu;
        menuMode["PrimaryButton"].started += CloseMenu;
    }
    void OnDisable()
    {
        var normal = _input.actions.FindActionMap("XRI RightHand");
        var menuMode = _input.actions.FindActionMap("XRI RightHand Menu");
        normal["PrimaryButton"].started -= OpenMenu; 
        menuMode["PrimaryButton"].started += CloseMenu;
    }

    private void CloseMenu(InputAction.CallbackContext obj)
    {
        menuObj.SetActive(false);
        _input.SwitchCurrentActionMap("XRI RightHand");
    }

    private void OpenMenu(InputAction.CallbackContext obj)
    {
        menuObj.SetActive(true);
        _input.SwitchCurrentActionMap("XRI RightHand Menu");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
