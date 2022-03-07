using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PointerEventTest : MonoBehaviour,IPointerClickHandler, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.LogError("Click");
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.LogError("PointerDown");
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.LogError("PointerUp");
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.LogError("PointerEnter");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.LogError("PointerExit");
    }
}
