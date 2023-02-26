using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CardMovement : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{

    Camera MainCamera;
    Vector2 offset;
    public Transform DefaultParent;

    //How i can undersend, Awake block starts, when the game starts and here we getting our camera component and turn up Raycasts
    //becouse Unity can check the mouse cursor by raycasting lasers from object to cursor, or somthing like this
    void Awake()
    {
        MainCamera = Camera.allCameras[0];
        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }

    // Start block starts when the object has just been created, and here we bloking raycasts for GameObjects
    //his parent not a Player cancel the probability to drag this GameObject
    void Start()
    {
        if (transform.parent == GetComponent<CardVisual>().Player) GetComponent<CanvasGroup>().blocksRaycasts = true;
        else GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    //Calculating offset and assign to this gameObject parent a parent of his parent for getting it to high layer on Canvas
    public void OnBeginDrag(PointerEventData eventData)
    {
        offset = transform.position - MainCamera.ScreenToWorldPoint(eventData.position);

        DefaultParent = transform.parent;

        transform.SetParent(DefaultParent.parent);
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    //assign to newPos a cursor position in World Perpective and change position of GO to this position + offset
    public void OnDrag(PointerEventData eventData)
    {
        Vector2 newPos = MainCamera.ScreenToWorldPoint(eventData.position);
        transform.position = newPos + offset;
    }

    //Set to this GO new or old Parent. Code on FieldDrop works first and it can change DefaultParent in this code
    public void OnEndDrag(PointerEventData eventData)
    {
        transform.SetParent(DefaultParent);
        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }
}
