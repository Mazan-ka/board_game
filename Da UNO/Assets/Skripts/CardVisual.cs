using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardVisual : MonoBehaviour
{
    public Card SelfCard;
    private Transform Oponent;
    private Transform Player;
    private Transform Field;

    public void SetOponent(Transform op)
    {
        Oponent = op;
    }

    public void SetPlayer(Transform pl)
    {
        Player = pl;
    }

    public void SetField(Transform fl)
    {
        Field = fl;
    }


    public void ShowCard(Card card)
    {
        SelfCard = card;
        //gameObject.GetComponent<Image>().sprite = card.Logo;
        //preserveAspect = true;
    }

    void Start()
    {
        if ((gameObject.transform.parent == Player) | (gameObject.transform.parent == Field))
        {
            GetComponent<Image>().sprite = Resources.Load<Sprite>(SelfCard.Logo);
        }
        else if(gameObject.transform.parent == Oponent)
        {
            GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/UNO/uno_empty");
        }
    }
}
