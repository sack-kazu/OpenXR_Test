using UnityEngine;
using UnityEngine.EventSystems;
public class UGUIDragSample : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    private RectTransform _rectTransform;
 
    private void Awake()
    {
        _rectTransform = transform as RectTransform;   
    }
    
    public void OnDrag(PointerEventData eventData)
    {
        // Overlay の場合
        //_rectTransform.anchoredPosition += eventData.delta;
        // それ以外の場合
        Vector2 outPos = Vector2.zero;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
                (RectTransform) _rectTransform.parent,
                eventData.position,
                eventData.pressEventCamera,
                out outPos);
            
        _rectTransform.localPosition = outPos;
    }
 
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.LogError("BeginDrag");
    }
 
    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.LogError("EndDrag");
    }
}