using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CardMovement : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{

    Camera MainCamera;
    Vector2 offset;
    public Transform DefaultParent;

    void Awake()
    {
        MainCamera = Camera.allCameras[0];
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        offset = transform.position - MainCamera.ScreenToWorldPoint(eventData.position);

        DefaultParent = transform.parent;

        transform.SetParent(DefaultParent.parent);
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 newPos = MainCamera.ScreenToWorldPoint(eventData.position);
        transform.position = newPos + offset;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.SetParent(DefaultParent);
    }
}
