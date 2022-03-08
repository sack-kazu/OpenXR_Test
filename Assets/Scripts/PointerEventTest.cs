using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PointerEventTest : MonoBehaviour,IPointerClickHandler, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] Text _text; 
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.LogError("Click");
        _text.text = "OnPointerClick";
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.LogError("PointerDown");
        _text.text = "PointerDown";
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.LogError("PointerUp");
        _text.text = "PointerUp";
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.LogError("PointerEnter");
        _text.text = "PointerEnter";
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.LogError("PointerExit");
        _text.text = "PointerExit";
    }
}
