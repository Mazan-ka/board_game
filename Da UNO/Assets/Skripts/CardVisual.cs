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
    public Transform Field;

    //Toggle to keep some atributes private
    public void SetPlayer(Transform pl) { Player = pl; }
    public void SetField(Transform fl) { Field = fl; }

    //Cheking transform parent of this gameObject and Player, Oponent and field
    //Assign appropriate sprites based on results
    void Start()
    {
        GetComponent<Image>().sprite = Resources.Load<Sprite>(SelfCard.Logo);
        /*if ((gameObject.transform.parent == Player) | (gameObject.transform.parent == Field))
        {
            GetComponent<Image>().sprite = Resources.Load<Sprite>(SelfCard.Logo);
        }
        else {GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/UNO/uno_empty");}*/
    }
}
