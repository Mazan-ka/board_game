using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using static CardMovement;

public class FieldDrop : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        CardMovement card = eventData.pointerDrag.GetComponent<CardMovement>();

        if (card)
        {
            Destroy(transform.GetChild(0).gameObject);
            card.DefaultParent = transform;
        }

    }
}
