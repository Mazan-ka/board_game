using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardVisual : MonoBehaviour
{
    public Card SelfCard;

    public void ShowCard(Card card)
    {
        SelfCard = card;
        gameObject.GetComponent<Image>().sprite = card.Logo;
        //preserveAspect = true;
    }

    void Start()
    {
        ShowCard(Game.Decks[transform.GetSiblingIndex()]);
    }
}
