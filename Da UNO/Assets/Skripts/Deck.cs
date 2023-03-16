using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public struct Card
{
    public int Number;
    public string Color;
    public string Logo;
    public bool Draw4;
    public bool Choose;

    //Constructor for struct Card
    //It needs to initialing all atributes
    public Card(int number, string color, bool draw4, bool choose, string logo)
    {
        Number = number;
        Color = color;
        Draw4 = draw4;
        Choose = choose;
        Logo = logo;
    }
}

public static class Game
{
    //list with cards in Deck, My hand, Oponent hand and Discard
    public static List<Card> Deck, Discard, Op_1, Op_2, Op_3, Op_4, Op_5, Op_6, Op_7, Player;
}

public class Deck : MonoBehaviour
{
    //Here some toggles to transmite Transform vars into CardVisual script
    //Also here link to prefab to instantiate new prefab clone
    public Transform Oponent_1;
    public Transform Oponent_2;
    public Transform Oponent_3;
    public Transform Oponent_4;
    public Transform Oponent_5;
    public Transform Oponent_6;
    public Transform Oponent_7;
    public Transform Player;
    public Transform Field;
    public GameObject pref;
    public int TurnCounter;
    private int INeedCard = 0;
    public int TurnTimer;
    public bool Revers;
    public TextMeshProUGUI Timer;

    void Awake()
    {
        //lists needs to be initialing before its been used
        Game.Deck = new List<Card>();
        Game.Discard = new List<Card>();
        Game.Op_1 = new List<Card>();
        Game.Op_2 = new List<Card>();
        Game.Op_3 = new List<Card>();
        Game.Op_4 = new List<Card>();
        Game.Op_5 = new List<Card>();
        Game.Op_6 = new List<Card>();
        Game.Op_7 = new List<Card>();
        Game.Player = new List<Card>();
        //blue 0-9
        Game.Deck.Add(new Card(0, "blue", false, false, "Sprites/UNO/uno_blue0"));
        Game.Deck.Add(new Card(1, "blue", false, false, "Sprites/UNO/uno_blue1"));
        Game.Deck.Add(new Card(1, "blue", false, false, "Sprites/UNO/uno_blue1"));
        Game.Deck.Add(new Card(2, "blue", false, false, "Sprites/UNO/uno_blue2"));
        Game.Deck.Add(new Card(2, "blue", false, false, "Sprites/UNO/uno_blue2"));
        Game.Deck.Add(new Card(3, "blue", false, false, "Sprites/UNO/uno_blue3"));
        Game.Deck.Add(new Card(3, "blue", false, false, "Sprites/UNO/uno_blue3"));
        Game.Deck.Add(new Card(4, "blue", false, false, "Sprites/UNO/uno_blue4"));
        Game.Deck.Add(new Card(4, "blue", false, false, "Sprites/UNO/uno_blue4"));
        Game.Deck.Add(new Card(5, "blue", false, false, "Sprites/UNO/uno_blue5"));
        Game.Deck.Add(new Card(5, "blue", false, false, "Sprites/UNO/uno_blue5"));
        Game.Deck.Add(new Card(6, "blue", false, false, "Sprites/UNO/uno_blue6"));
        Game.Deck.Add(new Card(6, "blue", false, false, "Sprites/UNO/uno_blue6"));
        Game.Deck.Add(new Card(7, "blue", false, false, "Sprites/UNO/uno_blue7"));
        Game.Deck.Add(new Card(7, "blue", false, false, "Sprites/UNO/uno_blue7"));
        Game.Deck.Add(new Card(8, "blue", false, false, "Sprites/UNO/uno_blue8"));
        Game.Deck.Add(new Card(8, "blue", false, false, "Sprites/UNO/uno_blue8"));
        Game.Deck.Add(new Card(9, "blue", false, false, "Sprites/UNO/uno_blue9"));
        Game.Deck.Add(new Card(9, "blue", false, false, "Sprites/UNO/uno_blue9"));
        //red 0-9
        Game.Deck.Add(new Card(0, "red", false, false, "Sprites/UNO/uno_red0"));
        Game.Deck.Add(new Card(1, "red", false, false, "Sprites/UNO/uno_red1"));
        Game.Deck.Add(new Card(1, "red", false, false, "Sprites/UNO/uno_red1"));
        Game.Deck.Add(new Card(2, "red", false, false, "Sprites/UNO/uno_red2"));
        Game.Deck.Add(new Card(2, "red", false, false, "Sprites/UNO/uno_red2"));
        Game.Deck.Add(new Card(3, "red", false, false, "Sprites/UNO/uno_red3"));
        Game.Deck.Add(new Card(3, "red", false, false, "Sprites/UNO/uno_red3"));
        Game.Deck.Add(new Card(4, "red", false, false, "Sprites/UNO/uno_red4"));
        Game.Deck.Add(new Card(4, "red", false, false, "Sprites/UNO/uno_red4"));
        Game.Deck.Add(new Card(5, "red", false, false, "Sprites/UNO/uno_red5"));
        Game.Deck.Add(new Card(5, "red", false, false, "Sprites/UNO/uno_red5"));
        Game.Deck.Add(new Card(6, "red", false, false, "Sprites/UNO/uno_red6"));
        Game.Deck.Add(new Card(6, "red", false, false, "Sprites/UNO/uno_red6"));
        Game.Deck.Add(new Card(7, "red", false, false, "Sprites/UNO/uno_red7"));
        Game.Deck.Add(new Card(7, "red", false, false, "Sprites/UNO/uno_red7"));
        Game.Deck.Add(new Card(8, "red", false, false, "Sprites/UNO/uno_red8"));
        Game.Deck.Add(new Card(8, "red", false, false, "Sprites/UNO/uno_red8"));
        Game.Deck.Add(new Card(9, "red", false, false, "Sprites/UNO/uno_red9"));
        Game.Deck.Add(new Card(9, "red", false, false, "Sprites/UNO/uno_red9"));
        //green 0-9
        Game.Deck.Add(new Card(0, "green", false, false, "Sprites/UNO/uno_green0"));
        Game.Deck.Add(new Card(1, "green", false, false, "Sprites/UNO/uno_green1"));
        Game.Deck.Add(new Card(1, "green", false, false, "Sprites/UNO/uno_green1"));
        Game.Deck.Add(new Card(2, "green", false, false, "Sprites/UNO/uno_green2"));
        Game.Deck.Add(new Card(2, "green", false, false, "Sprites/UNO/uno_green2"));
        Game.Deck.Add(new Card(3, "green", false, false, "Sprites/UNO/uno_green3"));
        Game.Deck.Add(new Card(3, "green", false, false, "Sprites/UNO/uno_green3"));
        Game.Deck.Add(new Card(4, "green", false, false, "Sprites/UNO/uno_green4"));
        Game.Deck.Add(new Card(4, "green", false, false, "Sprites/UNO/uno_green4"));
        Game.Deck.Add(new Card(5, "green", false, false, "Sprites/UNO/uno_green5"));
        Game.Deck.Add(new Card(5, "green", false, false, "Sprites/UNO/uno_green5"));
        Game.Deck.Add(new Card(6, "green", false, false, "Sprites/UNO/uno_green6"));
        Game.Deck.Add(new Card(6, "green", false, false, "Sprites/UNO/uno_green6"));
        Game.Deck.Add(new Card(7, "green", false, false, "Sprites/UNO/uno_green7"));
        Game.Deck.Add(new Card(7, "green", false, false, "Sprites/UNO/uno_green7"));
        Game.Deck.Add(new Card(8, "green", false, false, "Sprites/UNO/uno_green8"));
        Game.Deck.Add(new Card(8, "green", false, false, "Sprites/UNO/uno_green8"));
        Game.Deck.Add(new Card(9, "green", false, false, "Sprites/UNO/uno_green9"));
        Game.Deck.Add(new Card(9, "green", false, false, "Sprites/UNO/uno_green9"));
        //yellow 0-9
        Game.Deck.Add(new Card(0, "yellow", false, false, "Sprites/UNO/uno_yellow0"));
        Game.Deck.Add(new Card(1, "yellow", false, false, "Sprites/UNO/uno_yellow1"));
        Game.Deck.Add(new Card(1, "yellow", false, false, "Sprites/UNO/uno_yellow1"));
        Game.Deck.Add(new Card(2, "yellow", false, false, "Sprites/UNO/uno_yellow2"));
        Game.Deck.Add(new Card(2, "yellow", false, false, "Sprites/UNO/uno_yellow2"));
        Game.Deck.Add(new Card(3, "yellow", false, false, "Sprites/UNO/uno_yellow3"));
        Game.Deck.Add(new Card(3, "yellow", false, false, "Sprites/UNO/uno_yellow3"));
        Game.Deck.Add(new Card(4, "yellow", false, false, "Sprites/UNO/uno_yellow4"));
        Game.Deck.Add(new Card(4, "yellow", false, false, "Sprites/UNO/uno_yellow4"));
        Game.Deck.Add(new Card(5, "yellow", false, false, "Sprites/UNO/uno_yellow5"));
        Game.Deck.Add(new Card(5, "yellow", false, false, "Sprites/UNO/uno_yellow5"));
        Game.Deck.Add(new Card(6, "yellow", false, false, "Sprites/UNO/uno_yellow6"));
        Game.Deck.Add(new Card(6, "yellow", false, false, "Sprites/UNO/uno_yellow6"));
        Game.Deck.Add(new Card(7, "yellow", false, false, "Sprites/UNO/uno_yellow7"));
        Game.Deck.Add(new Card(7, "yellow", false, false, "Sprites/UNO/uno_yellow7"));
        Game.Deck.Add(new Card(8, "yellow", false, false, "Sprites/UNO/uno_yellow8"));
        Game.Deck.Add(new Card(8, "yellow", false, false, "Sprites/UNO/uno_yellow8"));
        Game.Deck.Add(new Card(9, "yellow", false, false, "Sprites/UNO/uno_yellow9"));
        Game.Deck.Add(new Card(9, "yellow", false, false, "Sprites/UNO/uno_yellow9"));
        //Draw2
        Game.Deck.Add(new Card(10, "blue", false, false, "Sprites/UNO/uno_blue_plus2"));
        Game.Deck.Add(new Card(10, "blue", false, false, "Sprites/UNO/uno_blue_plus2"));
        Game.Deck.Add(new Card(10, "red", false, false, "Sprites/UNO/uno_red_plus2"));
        Game.Deck.Add(new Card(10, "red", false, false, "Sprites/UNO/uno_red_plus2"));
        Game.Deck.Add(new Card(10, "green", false, false, "Sprites/UNO/uno_green_plus2"));
        Game.Deck.Add(new Card(10, "green", false, false, "Sprites/UNO/uno_green_plus2"));
        Game.Deck.Add(new Card(10, "yellow", false, false, "Sprites/UNO/uno_yellow_plus2"));
        Game.Deck.Add(new Card(10, "yellow", false, false, "Sprites/UNO/uno_yellow_plus2"));
        //Revers
        Game.Deck.Add(new Card(11, "blue", false, false, "Sprites/UNO/uno_blue_arrows"));
        Game.Deck.Add(new Card(11, "blue", false, false, "Sprites/UNO/uno_blue_arrows"));
        Game.Deck.Add(new Card(11, "red", false, false, "Sprites/UNO/uno_red_arrows"));
        Game.Deck.Add(new Card(11, "red", false, false, "Sprites/UNO/uno_red_arrows"));
        Game.Deck.Add(new Card(11, "green", false, false, "Sprites/UNO/uno_green_arrows"));
        Game.Deck.Add(new Card(11, "green", false, false, "Sprites/UNO/uno_green_arrows"));
        Game.Deck.Add(new Card(11, "yellow", false, false, "Sprites/UNO/uno_yellow_arrows"));
        Game.Deck.Add(new Card(11, "yellow", false, false, "Sprites/UNO/uno_yellow_arrows"));
        //Skip
        Game.Deck.Add(new Card(12, "blue", false, false, "Sprites/UNO/uno_blue_forbid"));
        Game.Deck.Add(new Card(12, "blue", false, false, "Sprites/UNO/uno_blue_forbid"));
        Game.Deck.Add(new Card(12, "red", false, false, "Sprites/UNO/uno_red_forbid"));
        Game.Deck.Add(new Card(12, "red", false, false, "Sprites/UNO/uno_red_forbid"));
        Game.Deck.Add(new Card(12, "green", false, false, "Sprites/UNO/uno_green_forbid"));
        Game.Deck.Add(new Card(12, "green", false, false, "Sprites/UNO/uno_green_forbid"));
        Game.Deck.Add(new Card(12, "yellow", false, false, "Sprites/UNO/uno_yellow_forbid"));
        Game.Deck.Add(new Card(12, "yellow", false, false, "Sprites/UNO/uno_yellow_forbid"));
        //Choose
        Game.Deck.Add(new Card(13, "null", false, true, "Sprites/UNO/uno_empty_wild"));
        Game.Deck.Add(new Card(13, "null", false, true, "Sprites/UNO/uno_empty_wild"));
        Game.Deck.Add(new Card(13, "null", false, true, "Sprites/UNO/uno_empty_wild"));
        Game.Deck.Add(new Card(13, "null", false, true, "Sprites/UNO/uno_empty_wild"));
        //Draw4
        Game.Deck.Add(new Card(14, "null", true, true, "Sprites/UNO/uno_empty_plus4"));
        Game.Deck.Add(new Card(14, "null", true, true, "Sprites/UNO/uno_empty_plus4"));
        Game.Deck.Add(new Card(14, "null", true, true, "Sprites/UNO/uno_empty_plus4"));
        Game.Deck.Add(new Card(14, "null", true, true, "Sprites/UNO/uno_empty_plus4"));
    }

    //Triggerd when mouse down on colider of this GameObject
    //Doesnt need interface providing because its standart function in MonoBehaviour
    void OnMouseDown()
    {
        if (TurnCounter == -1)
        {
            //giving cards to MyHad
            GiveCards(4, Player, Game.Player);
            //giving crads to OponentHand (it needs to be new name, rather than newCard)
            GiveCards(4, Oponent_1, Game.Op_1);
            GiveCards(4, Oponent_2, Game.Op_2);
            GiveCards(4, Oponent_3, Game.Op_3);
            GiveCards(4, Oponent_4, Game.Op_4);
            GiveCards(4, Oponent_5, Game.Op_5);
            GiveCards(4, Oponent_6, Game.Op_6);
            GiveCards(4, Oponent_7, Game.Op_7);
            //giving openning card in fied if here no cards, to evade the mistake
            if (Field.childCount == 0) GiveCards(1, Field, Game.Discard);

            ChangeTurn();
        }
        else if (TurnCounter == 0)
        {
            if (INeedCard < 3)
            {
                GiveCards(1, Player, Game.Player);
                INeedCard++;
            }
        }
    }

    void Start()
    {
        TurnCounter = -1;
        TurnTimer = 30;
        Revers = false;
        Timer.text = TurnTimer.ToString();
    }

    //Отрепетировать нормально реакцию на карты, плюс замутить при раздаче игнор карт модификаторов

    public void ChangeTurn()
    {
        StopAllCoroutines();

        TurnTimer = 30;

        if (Game.Deck.Count < 3) ShuffleDeck();

        TurnCounter++;
        if (TurnCounter == 0 | TurnCounter == 8) Field.GetComponent<FieldDrop>().SetMyTurn();
        if (TurnCounter == 8) TurnCounter = 0;
        Debug.Log(TurnCounter);

        StartCoroutine(TurnWaiter());
    }

    /*    public Transform GetPlayerByTurn(int turn)
        {
            switch (turn)
            {
                case 0:
                    return Player;
                case 1:
                    return Oponent_1;
                case 2:
                    return Oponent_2;
                case 3:
                    return Oponent_3;
                case 4:
                    return Oponent_4;
                case 5:
                    return Oponent_5;
                case 6:
                    return Oponent_6;
                case 7:
                    return Oponent_7;
                default:
                    return Player;
            }
        }

        public List<Card> GetHandByTurn(int turn)
        {
            switch (turn)
            {
                case 0:
                    return Game.Player;
                case 1:
                    return Game.Op_1;
                case 2:
                    return Game.Op_2;
                case 3:
                    return Game.Op_3;
                case 4:
                    return Game.Op_4;
                case 5:
                    return Game.Op_5;
                case 6:
                    return Game.Op_6;
                case 7:
                    return Game.Op_7;
                default :
                    return Game.Player;
            }
        }*/

    private IEnumerator TurnWaiter()
    {
        while (TurnTimer-- > 0)
        {
            Timer.text = TurnTimer.ToString();

            switch (TurnCounter)
            {
                case 0:
                    if (!Field.GetComponent<FieldDrop>().GetMyTurn())
                    {
                        Game.Player.RemoveAt(CheckCard(GetCardOnBoard(), Game.Player));
                        INeedCard = 0;
                        ChangeTurn();
                    }
                    else if (INeedCard == 3)
                    {
                        Field.GetComponent<FieldDrop>().SetNotMyTurn();
                        INeedCard = 0;
                        ChangeTurn();
                    }
                    break;
                case 1:
                    if (TurnTimer == 25) Turn(Oponent_1, Game.Op_1);
                    break;
                case 2:
                    if (TurnTimer == 25) Turn(Oponent_2, Game.Op_2);
                    break;
                case 3:
                    if (TurnTimer == 25) Turn(Oponent_3, Game.Op_3);
                    break;
                case 4:
                    if (TurnTimer == 25) Turn(Oponent_4, Game.Op_4);
                    break;
                case 5:
                    if (TurnTimer == 25) Turn(Oponent_5, Game.Op_5);
                    break;
                case 6:
                    if (TurnTimer == 25) Turn(Oponent_6, Game.Op_6);
                    break;
                case 7:
                    if (TurnTimer == 25) Turn(Oponent_7, Game.Op_7);
                    break;
            }

            yield return new WaitForSeconds(1);
        }
        GiveCards(3, Player, Game.Player);
        ChangeTurn();
    }

    private void ShuffleDeck()
    {
        Debug.Log("OK");
        List<Card> newList = new List<Card>();
        int count = Game.Discard.Count;
        for (int i = 0; i < count; i++)
        {
            int rand = Random.Range(0, Game.Discard.Count - 1);
            newList.Add(Game.Discard[rand]);
            Game.Discard.RemoveAt(rand);
        }
        Debug.Log(Game.Discard.Count);
        Debug.Log(Game.Deck.Count);
        Debug.Log(newList.Count);

        Game.Deck.AddRange(newList);
        Game.Discard.Clear();

        Debug.Log(Game.Deck.Count);
    }

    int CheckCard(Card card, List<Card> hand)
    {
        for (int i = 0; i < hand.Count; i++)
        {
            if (hand[i].Logo == card.Logo)
            {
                return i;
            }
        }
        Debug.Log("Not OK");
        return 99;
    }

    Card GetCardOnBoard()
    {
        return Field.GetChild(0).gameObject.GetComponent<CardVisual>().SelfCard;
    }

    string GetCardsFromList(List<Card> hand)
    {
        string str = "";
        for (int i = 0; i < hand.Count; i++)
        {
            str += hand[i].Logo;
            str += "\n";
        }
        return str;
    }

    void Turn(Transform whose, List<Card> hand)
    {

        Card cardOnField = GetCardOnBoard();
        bool can = false;
        for (int i = 0; i < hand.Count; i++)
        {
            if (hand[i].Number == cardOnField.Number | hand[i].Color == cardOnField.Color)
            {
                Destroy(Field.GetChild(0).gameObject);
                Destroy(whose.GetChild(i).gameObject);

                GameObject newCard = Instantiate(pref, Field, false);
                newCard.GetComponent<CardVisual>().SelfCard = hand[i];
                newCard.GetComponent<CardVisual>().SetPlayer(Player);
                newCard.GetComponent<CardVisual>().SetField(Field);

                Game.Discard.Add(hand[i]);
                hand.RemoveAt(i);
                can = true;
                break;
            }
        }
        if (!can)
        {
            for (int i = 0; i < 3; i++)
            {
                GiveCards(1, whose, hand);
                int last = hand.Count - 1;
                if (hand[last].Number == cardOnField.Number | hand[last].Color == cardOnField.Color)
                {
                    Destroy(Field.GetChild(0).gameObject);
                    Destroy(whose.GetChild(last).gameObject);

                    GameObject newCard = Instantiate(pref, Field, false);
                    newCard.GetComponent<CardVisual>().SelfCard = hand[last];
                    newCard.GetComponent<CardVisual>().SetPlayer(Player);
                    newCard.GetComponent<CardVisual>().SetField(Field);

                    Game.Discard.Add(hand[last]);
                    hand.RemoveAt(last);
                    break;
                }
            }
        }
        ChangeTurn();
    }

    void GiveCards(int amount, Transform toWhom, List<Card> hand)
    {
        for (int i = 0; i < amount; i++)
        {
            int rand = Random.Range(0, Game.Deck.Count - 1);

            //Create card with skript in toWhom
            GameObject newCard = Instantiate(pref, toWhom, false);

            //Tranmition card some parameters
            newCard.GetComponent<CardVisual>().SelfCard = Game.Deck[rand];
            newCard.GetComponent<CardVisual>().SetPlayer(Player);
            newCard.GetComponent<CardVisual>().SetField(Field);

            //Adding issued card in Discard list and delete this card in Deck
            hand.Add(Game.Deck[rand]);
            Game.Deck.RemoveAt(rand);
        }
    }
}
