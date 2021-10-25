using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class KeepTransformOnGrab : MonoBehaviour
{
    public void OnSelectEntered(XRRayInteractor xrRayInteractor)
    {
        Debug.Log("Select");
        xrRayInteractor.attachTransform.position = xrRayInteractor.selectTarget.transform.position;
        xrRayInteractor.attachTransform.rotation = xrRayInteractor.selectTarget.transform.rotation;
    }
}
