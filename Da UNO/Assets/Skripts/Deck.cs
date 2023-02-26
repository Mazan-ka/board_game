using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Card
{
    public int Number;
    public string Color;
    public string Logo;
    public bool Draw2;
    public bool Draw4;
    public bool Revers;
    public bool Skip;
    public bool Choose;

    //Constructor for struct Card
    //It needs to initialing all atributes
    public Card(int number, string color, bool draw2, bool revers, bool skip, bool draw4, bool choose, string logo)
    {
        Number = number;
        Color = color;
        Draw2 = draw2;
        Revers = revers;
        Skip = skip;
        Draw4 = draw4;
        Choose = choose;
        Logo = logo;
    }
}

public static class Game
{
    //list with cards in Deck, My hand, Oponent hand and Discard
    public static List<Card> Deck, Discard;
}

public class Deck : MonoBehaviour
{
    //Here some toggles to transmite Transform vars into CardVisual script
    //Also here link to prefab to instantiate new prefab clone
    public Transform Oponent;
    public Transform Player;
    public Transform Field;
    public GameObject pref;

    void Awake()
    {
        //lists needs to be initialing before its been used
        Game.Deck = new List<Card>();
        Game.Discard = new List<Card>();
        //blue 0-9
        Game.Deck.Add(new Card(0, "blue", false, false, false, false, false, "Sprites/UNO/uno_blue0"));
        Game.Deck.Add(new Card(1, "blue", false, false, false, false, false, "Sprites/UNO/uno_blue1"));
        Game.Deck.Add(new Card(1, "blue", false, false, false, false, false, "Sprites/UNO/uno_blue1"));
        Game.Deck.Add(new Card(2, "blue", false, false, false, false, false, "Sprites/UNO/uno_blue2"));
        Game.Deck.Add(new Card(2, "blue", false, false, false, false, false, "Sprites/UNO/uno_blue2"));
        Game.Deck.Add(new Card(3, "blue", false, false, false, false, false, "Sprites/UNO/uno_blue3"));
        Game.Deck.Add(new Card(3, "blue", false, false, false, false, false, "Sprites/UNO/uno_blue3"));
        Game.Deck.Add(new Card(4, "blue", false, false, false, false, false, "Sprites/UNO/uno_blue4"));
        Game.Deck.Add(new Card(4, "blue", false, false, false, false, false, "Sprites/UNO/uno_blue4"));
        Game.Deck.Add(new Card(5, "blue", false, false, false, false, false, "Sprites/UNO/uno_blue5"));
        Game.Deck.Add(new Card(5, "blue", false, false, false, false, false, "Sprites/UNO/uno_blue5"));
        Game.Deck.Add(new Card(6, "blue", false, false, false, false, false, "Sprites/UNO/uno_blue6"));
        Game.Deck.Add(new Card(6, "blue", false, false, false, false, false, "Sprites/UNO/uno_blue6"));
        Game.Deck.Add(new Card(7, "blue", false, false, false, false, false, "Sprites/UNO/uno_blue7"));
        Game.Deck.Add(new Card(7, "blue", false, false, false, false, false, "Sprites/UNO/uno_blue7"));
        Game.Deck.Add(new Card(8, "blue", false, false, false, false, false, "Sprites/UNO/uno_blue8"));
        Game.Deck.Add(new Card(8, "blue", false, false, false, false, false, "Sprites/UNO/uno_blue8"));
        Game.Deck.Add(new Card(9, "blue", false, false, false, false, false, "Sprites/UNO/uno_blue9"));
        Game.Deck.Add(new Card(9, "blue", false, false, false, false, false, "Sprites/UNO/uno_blue9"));
        //red 0-9
        Game.Deck.Add(new Card(0, "red", false, false, false, false, false, "Sprites/UNO/uno_red0"));
        Game.Deck.Add(new Card(1, "red", false, false, false, false, false, "Sprites/UNO/uno_red1"));
        Game.Deck.Add(new Card(1, "red", false, false, false, false, false, "Sprites/UNO/uno_red1"));
        Game.Deck.Add(new Card(2, "red", false, false, false, false, false, "Sprites/UNO/uno_red2"));
        Game.Deck.Add(new Card(2, "red", false, false, false, false, false, "Sprites/UNO/uno_red2"));
        Game.Deck.Add(new Card(3, "red", false, false, false, false, false, "Sprites/UNO/uno_red3"));
        Game.Deck.Add(new Card(3, "red", false, false, false, false, false, "Sprites/UNO/uno_red3"));
        Game.Deck.Add(new Card(4, "red", false, false, false, false, false, "Sprites/UNO/uno_red4"));
        Game.Deck.Add(new Card(4, "red", false, false, false, false, false, "Sprites/UNO/uno_red4"));
        Game.Deck.Add(new Card(5, "red", false, false, false, false, false, "Sprites/UNO/uno_red5"));
        Game.Deck.Add(new Card(5, "red", false, false, false, false, false, "Sprites/UNO/uno_red5"));
        Game.Deck.Add(new Card(6, "red", false, false, false, false, false, "Sprites/UNO/uno_red6"));
        Game.Deck.Add(new Card(6, "red", false, false, false, false, false, "Sprites/UNO/uno_red6"));
        Game.Deck.Add(new Card(7, "red", false, false, false, false, false, "Sprites/UNO/uno_red7"));
        Game.Deck.Add(new Card(7, "red", false, false, false, false, false, "Sprites/UNO/uno_red7"));
        Game.Deck.Add(new Card(8, "red", false, false, false, false, false, "Sprites/UNO/uno_red8"));
        Game.Deck.Add(new Card(8, "red", false, false, false, false, false, "Sprites/UNO/uno_red8"));
        Game.Deck.Add(new Card(9, "red", false, false, false, false, false, "Sprites/UNO/uno_red9"));
        Game.Deck.Add(new Card(9, "red", false, false, false, false, false, "Sprites/UNO/uno_red9"));
        //green 0-9
        Game.Deck.Add(new Card(0, "green", false, false, false, false, false, "Sprites/UNO/uno_green0"));
        Game.Deck.Add(new Card(1, "green", false, false, false, false, false, "Sprites/UNO/uno_green1"));
        Game.Deck.Add(new Card(1, "green", false, false, false, false, false, "Sprites/UNO/uno_green1"));
        Game.Deck.Add(new Card(2, "green", false, false, false, false, false, "Sprites/UNO/uno_green2"));
        Game.Deck.Add(new Card(2, "green", false, false, false, false, false, "Sprites/UNO/uno_green2"));
        Game.Deck.Add(new Card(3, "green", false, false, false, false, false, "Sprites/UNO/uno_green3"));
        Game.Deck.Add(new Card(3, "green", false, false, false, false, false, "Sprites/UNO/uno_green3"));
        Game.Deck.Add(new Card(4, "green", false, false, false, false, false, "Sprites/UNO/uno_green4"));
        Game.Deck.Add(new Card(4, "green", false, false, false, false, false, "Sprites/UNO/uno_green4"));
        Game.Deck.Add(new Card(5, "green", false, false, false, false, false, "Sprites/UNO/uno_green5"));
        Game.Deck.Add(new Card(5, "green", false, false, false, false, false, "Sprites/UNO/uno_green5"));
        Game.Deck.Add(new Card(6, "green", false, false, false, false, false, "Sprites/UNO/uno_green6"));
        Game.Deck.Add(new Card(6, "green", false, false, false, false, false, "Sprites/UNO/uno_green6"));
        Game.Deck.Add(new Card(7, "green", false, false, false, false, false, "Sprites/UNO/uno_green7"));
        Game.Deck.Add(new Card(7, "green", false, false, false, false, false, "Sprites/UNO/uno_green7"));
        Game.Deck.Add(new Card(8, "green", false, false, false, false, false, "Sprites/UNO/uno_green8"));
        Game.Deck.Add(new Card(8, "green", false, false, false, false, false, "Sprites/UNO/uno_green8"));
        Game.Deck.Add(new Card(9, "green", false, false, false, false, false, "Sprites/UNO/uno_green9"));
        Game.Deck.Add(new Card(9, "green", false, false, false, false, false, "Sprites/UNO/uno_green9"));
        //yellow 0-9
        Game.Deck.Add(new Card(0, "yellow", false, false, false, false, false, "Sprites/UNO/uno_yellow0"));
        Game.Deck.Add(new Card(1, "yellow", false, false, false, false, false, "Sprites/UNO/uno_yellow1"));
        Game.Deck.Add(new Card(1, "yellow", false, false, false, false, false, "Sprites/UNO/uno_yellow1"));
        Game.Deck.Add(new Card(2, "yellow", false, false, false, false, false, "Sprites/UNO/uno_yellow2"));
        Game.Deck.Add(new Card(2, "yellow", false, false, false, false, false, "Sprites/UNO/uno_yellow2"));
        Game.Deck.Add(new Card(3, "yellow", false, false, false, false, false, "Sprites/UNO/uno_yellow3"));
        Game.Deck.Add(new Card(3, "yellow", false, false, false, false, false, "Sprites/UNO/uno_yellow3"));
        Game.Deck.Add(new Card(4, "yellow", false, false, false, false, false, "Sprites/UNO/uno_yellow4"));
        Game.Deck.Add(new Card(4, "yellow", false, false, false, false, false, "Sprites/UNO/uno_yellow4"));
        Game.Deck.Add(new Card(5, "yellow", false, false, false, false, false, "Sprites/UNO/uno_yellow5"));
        Game.Deck.Add(new Card(5, "yellow", false, false, false, false, false, "Sprites/UNO/uno_yellow5"));
        Game.Deck.Add(new Card(6, "yellow", false, false, false, false, false, "Sprites/UNO/uno_yellow6"));
        Game.Deck.Add(new Card(6, "yellow", false, false, false, false, false, "Sprites/UNO/uno_yellow6"));
        Game.Deck.Add(new Card(7, "yellow", false, false, false, false, false, "Sprites/UNO/uno_yellow7"));
        Game.Deck.Add(new Card(7, "yellow", false, false, false, false, false, "Sprites/UNO/uno_yellow7"));
        Game.Deck.Add(new Card(8, "yellow", false, false, false, false, false, "Sprites/UNO/uno_yellow8"));
        Game.Deck.Add(new Card(8, "yellow", false, false, false, false, false, "Sprites/UNO/uno_yellow8"));
        Game.Deck.Add(new Card(9, "yellow", false, false, false, false, false, "Sprites/UNO/uno_yellow9"));
        Game.Deck.Add(new Card(9, "yellow", false, false, false, false, false, "Sprites/UNO/uno_yellow9"));
    }

    //Triggerd when mouse down on colider of this GameObject
    //Doesnt need interface providing because its standart function in MonoBehaviour
    void OnMouseDown()
    {
        //giving cards to MyHad
        GiveCards(4, Player);
        //giving crads to OponentHand (it needs to be new name, rather than newCard)
        GiveCards(4, Oponent);
        //giving openning card in fied if here no cards, to evade the mistake
        if(Field.childCount == 0) GiveCards(1, Field);
    }

    void GiveCards(int amount, Transform toWhom)
    {
        for (int i = 0; i < amount; i++)
        {
            int rand = Random.Range(0, Game.Deck.Count - 1);

            //Create card with skript in toWhom
            GameObject newCard = Instantiate(pref, toWhom, false);

            //Tranmition card some parameters
            newCard.GetComponent<CardVisual>().SelfCard = Game.Deck[rand];
            newCard.GetComponent<CardVisual>().SetPlayer(Player);
            newCard.GetComponent<CardVisual>().SetOponent(Oponent);
            newCard.GetComponent<CardVisual>().SetField(Field);

            //Adding issued card in Discard list and delete this card in Deck
            Game.Discard.Add(Game.Deck[rand]);
            Game.Deck.RemoveAt(rand);
        }
    }
}
