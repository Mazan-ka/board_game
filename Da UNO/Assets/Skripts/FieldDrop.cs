using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using static CardMovement;

public class FieldDrop : MonoBehaviour, IDropHandler
{
    private bool MyTurn;
    public Card newCard;

    public void SetMyTurn()
    {
        MyTurn = true;
    }

    public void SetNotMyTurn()
    {
        MyTurn = false;
    }

    public bool GetMyTurn()
    {
        return MyTurn;
    }

    public void OnDrop(PointerEventData eventData)
    {
        //Collect info about card on field and card we'd try to drop
        Card recentCard = transform.GetChild(0).GetComponent<CardVisual>().SelfCard;
        newCard = eventData.pointerDrag.GetComponent<CardVisual>().SelfCard;

        CardMovement card = eventData.pointerDrag.GetComponent<CardMovement>();

        if ((newCard.Number == recentCard.Number) | (newCard.Color == recentCard.Color) | newCard.Color == "null")
        {
            if (card) //if object have been transmitted it became true
            {
                if (MyTurn)
                {
                    //Deleting first child in this object hierarchy and change DefaultParent in CardMovement skript
                    Destroy(transform.GetChild(0).gameObject);
                    card.DefaultParent = transform;
                    MyTurn = false;
                }
            }
        }
        else return;
    }
}
