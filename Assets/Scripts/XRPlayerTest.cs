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
        _input.actions["PrimaryButton"].started += OpenMenu;
    }
    void OnDisable()
    {
        _input.actions["PrimaryButton"].started -= OpenMenu; 
    }

    private void OpenMenu(InputAction.CallbackContext obj)
    {
        menuObj.SetActive(!menuObj.activeSelf);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
