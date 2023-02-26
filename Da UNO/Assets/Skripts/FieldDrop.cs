using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using static CardMovement;

public class FieldDrop : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        //Collect info about card on field and card we'd try to drop
        Card recentCard = transform.GetChild(0).GetComponent<CardVisual>().SelfCard;
        Card newCard = eventData.pointerDrag.GetComponent<CardVisual>().SelfCard;

        CardMovement card = eventData.pointerDrag.GetComponent<CardMovement>();

        if ((newCard.Number == recentCard.Number) | (newCard.Color == recentCard.Color))
        {
            if (card) //if object have been transmitted it became true
            {
                //Deleting first child in this object hierarchy and change DefaultParent in CardMovement skript
                Destroy(transform.GetChild(0).gameObject);
                card.DefaultParent = transform;
            }
        }
        else return;
    }
}
