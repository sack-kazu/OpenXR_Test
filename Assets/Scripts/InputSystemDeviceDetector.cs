using UnityEngine;
using UnityEngine.InputSystem;

public class InputSystemDeviceDetector : MonoBehaviour
{
    [SerializeField] UnityEngine.UI.Text _text;
    string _oculus = "Oculus", _valve = "Valve", _htc = "HTC";
    private void Awake()
    {
        _text.text = $"Awake";
        InputSystem.onDeviceChange += OnDeviceChange;
    }

    private void OnApplicationQuit()
    {
        InputSystem.onDeviceChange -= OnDeviceChange;
    }
    
    private void OnDeviceChange(InputDevice inputDevice, InputDeviceChange inputDeviceChange)
    {
        _text.text = $"OnDeviceChange: {inputDeviceChange}";
        switch (inputDeviceChange)
        {
            case InputDeviceChange.Added:
                OnDeviceAdded(inputDevice);
                break;
        }
    }

    private void OnDeviceAdded(InputDevice inputDevice)
    {
        Debug.Log($"Device Added: {inputDevice.displayName}\nManufacturer: {inputDevice.description.manufacturer}\nProduct: {inputDevice.description.product}");
        if(inputDevice.description.manufacturer  == _oculus){
            _text.text = $"This is {_oculus} device.";
        }else if(inputDevice.description.manufacturer  == _valve){
            _text.text = $"This is {_valve} device.";
        }else if(inputDevice.description.manufacturer  == _htc){
            _text.text = $"This is {_htc} device.";
        }else{
            _text.text = $"This is unknown device.";
        }
    }

    private void OnDeviceRemoved(InputDevice inputDevice)
    {
        Debug.Log($"Device Removed: {inputDevice.displayName}");
    }
}
