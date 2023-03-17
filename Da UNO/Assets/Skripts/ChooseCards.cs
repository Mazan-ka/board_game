using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseCards : MonoBehaviour
{
    private Deck deck;

    void Start()
    {
        deck = GameObject.FindWithTag("Deck").transform.GetComponent<Deck>();
    }

    void OnMouseDown()
    {
        if (gameObject.tag == "ChooseBlue") deck.SetBlue();
        else if(gameObject.tag == "ChooseRed") deck.SetRed();
        else if (gameObject.tag == "ChooseGreen") deck.SetGreen();
        else if (gameObject.tag == "ChooseYellow") deck.SetYellow();
    }
}