using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardVisual : MonoBehaviour
{
    //Funn fact, only in MonoBehavior we can work with the object on whitch this script is located
    //by using gameObject or nothig (Just write somthing, like transform.GetComponent...)
    public Card SelfCard;
    public Transform Player;
    private Transform Oponent;
    private Transform Field;

    //Toggle to keep some atributes private
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

    //Cheking transform parent of this gameObject and Player, Oponent and field
    //Assign appropriate sprites based on results
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
