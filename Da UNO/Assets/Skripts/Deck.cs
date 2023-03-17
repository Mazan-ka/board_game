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

    //Constructor for struct Card
    //It needs to initialing all atributes
    public Card(int number, string color, string logo)
    {
        Number = number;
        Color = color;
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
    public GameObject PrefBlue;
    public GameObject PrefRed;
    public GameObject PrefGreen;
    public GameObject PrefYellow;
    //make it private
    public bool ChooseBlue = false;
    public bool ChooseRed = false;
    public bool ChooseGreen = false;
    public bool ChooseYellow = false;
    //
    public int TurnCounter;
    private int INeedCard = 0;
    public int TurnTimer = 0;
    public int ChooseTimer = 0;
    public bool Revers;
    public bool Skip;
    public bool Draw2;
    public bool Draw4;
    public bool Choose;
    public bool BotChoose;
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
        Game.Deck.Add(new Card(0, "blue", "Sprites/UNO/uno_blue0"));
        Game.Deck.Add(new Card(1, "blue", "Sprites/UNO/uno_blue1"));
        Game.Deck.Add(new Card(1, "blue", "Sprites/UNO/uno_blue1"));
        Game.Deck.Add(new Card(2, "blue", "Sprites/UNO/uno_blue2"));
        Game.Deck.Add(new Card(2, "blue", "Sprites/UNO/uno_blue2"));
        Game.Deck.Add(new Card(3, "blue", "Sprites/UNO/uno_blue3"));
        Game.Deck.Add(new Card(3, "blue", "Sprites/UNO/uno_blue3"));
        Game.Deck.Add(new Card(4, "blue", "Sprites/UNO/uno_blue4"));
        Game.Deck.Add(new Card(4, "blue", "Sprites/UNO/uno_blue4"));
        Game.Deck.Add(new Card(5, "blue", "Sprites/UNO/uno_blue5"));
        Game.Deck.Add(new Card(5, "blue", "Sprites/UNO/uno_blue5"));
        Game.Deck.Add(new Card(6, "blue", "Sprites/UNO/uno_blue6"));
        Game.Deck.Add(new Card(6, "blue", "Sprites/UNO/uno_blue6"));
        Game.Deck.Add(new Card(7, "blue", "Sprites/UNO/uno_blue7"));
        Game.Deck.Add(new Card(7, "blue", "Sprites/UNO/uno_blue7"));
        Game.Deck.Add(new Card(8, "blue", "Sprites/UNO/uno_blue8"));
        Game.Deck.Add(new Card(8, "blue", "Sprites/UNO/uno_blue8"));
        Game.Deck.Add(new Card(9, "blue", "Sprites/UNO/uno_blue9"));
        Game.Deck.Add(new Card(9, "blue", "Sprites/UNO/uno_blue9"));
        //red 0-9
        Game.Deck.Add(new Card(0, "red", "Sprites/UNO/uno_red0"));
        Game.Deck.Add(new Card(1, "red", "Sprites/UNO/uno_red1"));
        Game.Deck.Add(new Card(1, "red", "Sprites/UNO/uno_red1"));
        Game.Deck.Add(new Card(2, "red", "Sprites/UNO/uno_red2"));
        Game.Deck.Add(new Card(2, "red", "Sprites/UNO/uno_red2"));
        Game.Deck.Add(new Card(3, "red", "Sprites/UNO/uno_red3"));
        Game.Deck.Add(new Card(3, "red", "Sprites/UNO/uno_red3"));
        Game.Deck.Add(new Card(4, "red", "Sprites/UNO/uno_red4"));
        Game.Deck.Add(new Card(4, "red", "Sprites/UNO/uno_red4"));
        Game.Deck.Add(new Card(5, "red", "Sprites/UNO/uno_red5"));
        Game.Deck.Add(new Card(5, "red", "Sprites/UNO/uno_red5"));
        Game.Deck.Add(new Card(6, "red", "Sprites/UNO/uno_red6"));
        Game.Deck.Add(new Card(6, "red", "Sprites/UNO/uno_red6"));
        Game.Deck.Add(new Card(7, "red", "Sprites/UNO/uno_red7"));
        Game.Deck.Add(new Card(7, "red", "Sprites/UNO/uno_red7"));
        Game.Deck.Add(new Card(8, "red", "Sprites/UNO/uno_red8"));
        Game.Deck.Add(new Card(8, "red", "Sprites/UNO/uno_red8"));
        Game.Deck.Add(new Card(9, "red", "Sprites/UNO/uno_red9"));
        Game.Deck.Add(new Card(9, "red", "Sprites/UNO/uno_red9"));
        //green 0-9
        Game.Deck.Add(new Card(0, "green", "Sprites/UNO/uno_green0"));
        Game.Deck.Add(new Card(1, "green", "Sprites/UNO/uno_green1"));
        Game.Deck.Add(new Card(1, "green", "Sprites/UNO/uno_green1"));
        Game.Deck.Add(new Card(2, "green", "Sprites/UNO/uno_green2"));
        Game.Deck.Add(new Card(2, "green", "Sprites/UNO/uno_green2"));
        Game.Deck.Add(new Card(3, "green", "Sprites/UNO/uno_green3"));
        Game.Deck.Add(new Card(3, "green", "Sprites/UNO/uno_green3"));
        Game.Deck.Add(new Card(4, "green", "Sprites/UNO/uno_green4"));
        Game.Deck.Add(new Card(4, "green", "Sprites/UNO/uno_green4"));
        Game.Deck.Add(new Card(5, "green", "Sprites/UNO/uno_green5"));
        Game.Deck.Add(new Card(5, "green", "Sprites/UNO/uno_green5"));
        Game.Deck.Add(new Card(6, "green", "Sprites/UNO/uno_green6"));
        Game.Deck.Add(new Card(6, "green", "Sprites/UNO/uno_green6"));
        Game.Deck.Add(new Card(7, "green", "Sprites/UNO/uno_green7"));
        Game.Deck.Add(new Card(7, "green", "Sprites/UNO/uno_green7"));
        Game.Deck.Add(new Card(8, "green", "Sprites/UNO/uno_green8"));
        Game.Deck.Add(new Card(8, "green", "Sprites/UNO/uno_green8"));
        Game.Deck.Add(new Card(9, "green", "Sprites/UNO/uno_green9"));
        Game.Deck.Add(new Card(9, "green", "Sprites/UNO/uno_green9"));
        //yellow 0-9
        Game.Deck.Add(new Card(0, "yellow", "Sprites/UNO/uno_yellow0"));
        Game.Deck.Add(new Card(1, "yellow", "Sprites/UNO/uno_yellow1"));
        Game.Deck.Add(new Card(1, "yellow", "Sprites/UNO/uno_yellow1"));
        Game.Deck.Add(new Card(2, "yellow", "Sprites/UNO/uno_yellow2"));
        Game.Deck.Add(new Card(2, "yellow", "Sprites/UNO/uno_yellow2"));
        Game.Deck.Add(new Card(3, "yellow", "Sprites/UNO/uno_yellow3"));
        Game.Deck.Add(new Card(3, "yellow", "Sprites/UNO/uno_yellow3"));
        Game.Deck.Add(new Card(4, "yellow", "Sprites/UNO/uno_yellow4"));
        Game.Deck.Add(new Card(4, "yellow", "Sprites/UNO/uno_yellow4"));
        Game.Deck.Add(new Card(5, "yellow", "Sprites/UNO/uno_yellow5"));
        Game.Deck.Add(new Card(5, "yellow", "Sprites/UNO/uno_yellow5"));
        Game.Deck.Add(new Card(6, "yellow", "Sprites/UNO/uno_yellow6"));
        Game.Deck.Add(new Card(6, "yellow", "Sprites/UNO/uno_yellow6"));
        Game.Deck.Add(new Card(7, "yellow", "Sprites/UNO/uno_yellow7"));
        Game.Deck.Add(new Card(7, "yellow", "Sprites/UNO/uno_yellow7"));
        Game.Deck.Add(new Card(8, "yellow", "Sprites/UNO/uno_yellow8"));
        Game.Deck.Add(new Card(8, "yellow", "Sprites/UNO/uno_yellow8"));
        Game.Deck.Add(new Card(9, "yellow", "Sprites/UNO/uno_yellow9"));
        Game.Deck.Add(new Card(9, "yellow", "Sprites/UNO/uno_yellow9"));
        //Draw2
        Game.Deck.Add(new Card(10, "blue", "Sprites/UNO/uno_blue_plus2"));
        Game.Deck.Add(new Card(10, "blue", "Sprites/UNO/uno_blue_plus2"));
        Game.Deck.Add(new Card(10, "red", "Sprites/UNO/uno_red_plus2"));
        Game.Deck.Add(new Card(10, "red", "Sprites/UNO/uno_red_plus2"));
        Game.Deck.Add(new Card(10, "green", "Sprites/UNO/uno_green_plus2"));
        Game.Deck.Add(new Card(10, "green", "Sprites/UNO/uno_green_plus2"));
        Game.Deck.Add(new Card(10, "yellow", "Sprites/UNO/uno_yellow_plus2"));
        Game.Deck.Add(new Card(10, "yellow", "Sprites/UNO/uno_yellow_plus2"));
        //Revers
        Game.Deck.Add(new Card(11, "blue", "Sprites/UNO/uno_blue_arrows"));
        Game.Deck.Add(new Card(11, "blue", "Sprites/UNO/uno_blue_arrows"));
        Game.Deck.Add(new Card(11, "red", "Sprites/UNO/uno_red_arrows"));
        Game.Deck.Add(new Card(11, "red", "Sprites/UNO/uno_red_arrows"));
        Game.Deck.Add(new Card(11, "green", "Sprites/UNO/uno_green_arrows"));
        Game.Deck.Add(new Card(11, "green", "Sprites/UNO/uno_green_arrows"));
        Game.Deck.Add(new Card(11, "yellow", "Sprites/UNO/uno_yellow_arrows"));
        Game.Deck.Add(new Card(11, "yellow", "Sprites/UNO/uno_yellow_arrows"));
        //Skip
        Game.Deck.Add(new Card(12, "blue", "Sprites/UNO/uno_blue_forbid"));
        Game.Deck.Add(new Card(12, "blue", "Sprites/UNO/uno_blue_forbid"));
        Game.Deck.Add(new Card(12, "red", "Sprites/UNO/uno_red_forbid"));
        Game.Deck.Add(new Card(12, "red", "Sprites/UNO/uno_red_forbid"));
        Game.Deck.Add(new Card(12, "green", "Sprites/UNO/uno_green_forbid"));
        Game.Deck.Add(new Card(12, "green", "Sprites/UNO/uno_green_forbid"));
        Game.Deck.Add(new Card(12, "yellow", "Sprites/UNO/uno_yellow_forbid"));
        Game.Deck.Add(new Card(12, "yellow", "Sprites/UNO/uno_yellow_forbid"));
    }

    private void AddSpecialCards()
    {
        //Choose
        Game.Deck.Add(new Card(13, "null", "Sprites/UNO/uno_empty_wild"));
        Game.Deck.Add(new Card(13, "null", "Sprites/UNO/uno_empty_wild"));
        Game.Deck.Add(new Card(13, "null", "Sprites/UNO/uno_empty_wild"));
        Game.Deck.Add(new Card(13, "null", "Sprites/UNO/uno_empty_wild"));
        //Draw4
        Game.Deck.Add(new Card(14, "null", "Sprites/UNO/uno_empty_plus4"));
        Game.Deck.Add(new Card(14, "null", "Sprites/UNO/uno_empty_plus4"));
        Game.Deck.Add(new Card(14, "null", "Sprites/UNO/uno_empty_plus4"));
        Game.Deck.Add(new Card(14, "null", "Sprites/UNO/uno_empty_plus4"));
    }

    //Triggerd when mouse down on colider of this GameObject
    //Doesnt need interface providing because its standart function in MonoBehaviour
    void OnMouseDown()
    {
        if (TurnCounter == -1)
        {
            //giving openning card in fied before adding special cards, to evade the mistake
            GiveCards(1, Field, Game.Discard);
            //adding special cards to deck
            AddSpecialCards();
            //giving cards to MyHad
            GiveCards(4, Player, Game.Player);
            //giving crads to Oponents Hands (it needs to be new name, rather than newCard)
            GiveCards(4, Oponent_1, Game.Op_1);
            GiveCards(4, Oponent_2, Game.Op_2);
            GiveCards(4, Oponent_3, Game.Op_3);
            GiveCards(4, Oponent_4, Game.Op_4);
            GiveCards(4, Oponent_5, Game.Op_5);
            GiveCards(4, Oponent_6, Game.Op_6);
            GiveCards(4, Oponent_7, Game.Op_7);

            ChangeTurn();
        }
        //if my turn, i can take  3 cards, but 3-rd card is end of turn
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
        //reset some variables ... for fun, idk
        TurnCounter = -1;
        TurnTimer = 30;
        ChooseTimer = 10;
        Revers = false;
        Timer.text = TurnTimer.ToString();
    }

    public void ChangeTurn()
    {
        StopAllCoroutines();

        TurnTimer = 30;

        if (Game.Deck.Count < 10) ShuffleDeck();

        //Turn Manager block:
        if (Revers)
        {
            Debug.Log("Revers");
            if (Skip)
            {
                Debug.Log("Revers Skip");
                TurnCounter -= 2;
            }
            else TurnCounter--;
        }
        else
        {
            if (Skip)
            {
                Debug.Log("Skip");
                TurnCounter += 2;
            }
            else TurnCounter++;
        }

        if (TurnCounter == 0 | TurnCounter == 8) Field.GetComponent<FieldDrop>().SetMyTurn();

        if (TurnCounter == 8) TurnCounter = 0;
        else if (TurnCounter == 9) TurnCounter = 1;
        else if (TurnCounter == -1) TurnCounter = 7;
        else if (TurnCounter == -2) TurnCounter = 6;

        Debug.Log(TurnCounter);

        //Draw Manager block:
        if (Draw2)
        {
            if(Revers)
            {
                if(TurnCounter == 0) GiveCards(2, GetPlayerByTurn(7), GetHandByTurn(TurnCounter));
                else GiveCards(2, GetPlayerByTurn(TurnCounter), GetHandByTurn(TurnCounter));
            }
            else
            {
                if (TurnCounter == 7) GiveCards(2, GetPlayerByTurn(0), GetHandByTurn(TurnCounter));
                else GiveCards(2, GetPlayerByTurn(TurnCounter), GetHandByTurn(TurnCounter));
            }
        }
        else if (Draw4)
        {
            if (Revers)
            {
                if (TurnCounter == 0) GiveCards(4, GetPlayerByTurn(7), GetHandByTurn(TurnCounter));
                else GiveCards(4, GetPlayerByTurn(TurnCounter - 1), GetHandByTurn(TurnCounter));
            }
            else
            {
                if (TurnCounter == 7) GiveCards(4, GetPlayerByTurn(0), GetHandByTurn(TurnCounter));
                else GiveCards(4, GetPlayerByTurn(TurnCounter - 1), GetHandByTurn(TurnCounter));
            }
        }

        //Choose Manager block
        if(BotChoose) //For bot, without animating
        {
            int rand = Random.Range(0, 3);

            if (rand == 0) ChooseBlue = true;
            else if (rand == 1) ChooseRed = true;
            else if (rand == 2) ChooseGreen = true;
            else if (rand == 3) ChooseYellow = true;

            //There is function that influence on logic of game
            ChooseTurn();
            BotChoose = false;
        }

        if (Choose) //For human, with animating
        {
            Instantiate(PrefBlue, Player.parent, false);
            Instantiate(PrefRed, Player.parent, false);
            Instantiate(PrefGreen, Player.parent, false);
            Instantiate(PrefYellow, Player.parent, false);

            //Because there no ways to do 1 coroutine, then some code and 2 coroutine
            //I had to call 2 coroutine after 1 and input code directly to 1 coroutine logic
            StartCoroutine(ChooseWaiter());
            Choose = false;

            //return because 2 coroutine has already been called by 1 coroutine, and parameters resets ibid
            return;
        }

        //Reset parameters, that needs to impact to 1 turn
        Skip = false;
        Draw2 = false;
        Draw4 = false;
        Choose = false;

        StartCoroutine(TurnWaiter());
    }

    private void ChooseTurn()
    {
        if (ChooseBlue)
        {
            Destroy(Field.GetChild(0).gameObject);

            GameObject newCard = Instantiate(pref, Field, false);
            newCard.GetComponent<CardVisual>().SelfCard = new Card(13, "blue", "Sprites/UNO/uno_blue_white");
            newCard.GetComponent<CardVisual>().SetPlayer(Player);
            newCard.GetComponent<CardVisual>().SetField(Field);
            ChooseBlue = false;
        }
        else if (ChooseRed)
        {
            Destroy(Field.GetChild(0).gameObject);

            GameObject newCard = Instantiate(pref, Field, false);
            newCard.GetComponent<CardVisual>().SelfCard = new Card(13, "red", "Sprites/UNO/uno_red_wild");
            newCard.GetComponent<CardVisual>().SetPlayer(Player);
            newCard.GetComponent<CardVisual>().SetField(Field);
            ChooseRed = false;
        }
        else if (ChooseGreen)
        {
            Destroy(Field.GetChild(0).gameObject);

            GameObject newCard = Instantiate(pref, Field, false);
            newCard.GetComponent<CardVisual>().SelfCard = new Card(13, "green", "Sprites/UNO/uno_green_wild");
            newCard.GetComponent<CardVisual>().SetPlayer(Player);
            newCard.GetComponent<CardVisual>().SetField(Field);
            ChooseGreen = false;
        }
        else if (ChooseYellow)
        {
            Destroy(Field.GetChild(0).gameObject);

            GameObject newCard = Instantiate(pref, Field, false);
            newCard.GetComponent<CardVisual>().SelfCard = new Card(13, "yellow", "Sprites/UNO/uno_yellow_wild");
            newCard.GetComponent<CardVisual>().SetPlayer(Player);
            newCard.GetComponent<CardVisual>().SetField(Field);
            ChooseYellow = false;
        }

        Destroy(GameObject.FindWithTag("ChooseBlue"));
        Destroy(GameObject.FindWithTag("ChooseRed"));
        Destroy(GameObject.FindWithTag("ChooseGreen"));
        Destroy(GameObject.FindWithTag("ChooseYellow")); 
    }

    private IEnumerator ChooseWaiter()
    {
        while (ChooseTimer-- >= -1)
        {
            Timer.text = ChooseTimer.ToString();
            if (ChooseBlue | ChooseRed | ChooseGreen | ChooseYellow)
            {
                ChooseTurn();
                break;
            }
            if (ChooseTimer == -1)
            {
                int rand = Random.Range(0, 3);

                if (rand == 0) ChooseBlue = true;
                else if (rand == 1) ChooseRed = true;
                else if (rand == 2) ChooseGreen = true;
                else if (rand == 3) ChooseYellow = true;

                ChooseTurn();
                break;
            }
            yield return new WaitForSeconds(1);
        }
        yield return StartCoroutine(TurnWaiter());
    }

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
                        //Function that rules what is card that player drop mean
                        Effect();
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
                    if (TurnTimer == 28) Turn(Oponent_1, Game.Op_1);
                    break;
                case 2:
                    if (TurnTimer == 28) Turn(Oponent_2, Game.Op_2);
                    break;
                case 3:
                    if (TurnTimer == 28) Turn(Oponent_3, Game.Op_3);
                    break;
                case 4:
                    if (TurnTimer == 28) Turn(Oponent_4, Game.Op_4);
                    break;
                case 5:
                    if (TurnTimer == 28) Turn(Oponent_5, Game.Op_5);
                    break;
                case 6:
                    if (TurnTimer == 28) Turn(Oponent_6, Game.Op_6);
                    break;
                case 7:
                    if (TurnTimer == 28) Turn(Oponent_7, Game.Op_7);
                    break;
            }

            yield return new WaitForSeconds(1);
        }
        //If time goes up, turn ends and player get 3 cards
        GiveCards(3, Player, Game.Player);
        ChangeTurn();
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

                //Function that rules what is card that bot drop mean
                EffectBot(hand[i]);

                Game.Discard.Add(hand[i]);
                hand.RemoveAt(i);
                can = true;
                break;
            }
            else if(hand[i].Color == "null")
            {
                Destroy(Field.GetChild(0).gameObject);
                Destroy(whose.GetChild(i).gameObject);

                EffectBot(hand[i]);

                Game.Discard.Add(hand[i]);
                hand.RemoveAt(i);
                can = true;
                break;
            }
        }
        //If bot have not needful card, he draw cards and analising them
        if (!can)
        {
            for (int i = 0; i < 3; i++)
            {
                GiveCards(1, whose, hand);

                Debug.Log("Draw " + i.ToString());

                int last = hand.Count - 1;

                if (hand[last].Number == cardOnField.Number | hand[last].Color == cardOnField.Color)
                {
                    Destroy(Field.GetChild(0).gameObject);
                    Destroy(whose.GetChild(last).gameObject);

                    GameObject newCard = Instantiate(pref, Field, false);
                    newCard.GetComponent<CardVisual>().SelfCard = hand[last];
                    newCard.GetComponent<CardVisual>().SetPlayer(Player);
                    newCard.GetComponent<CardVisual>().SetField(Field);

                    EffectBot(hand[last]);

                    Game.Discard.Add(hand[last]);
                    hand.RemoveAt(last);
                    break;
                }
                else if (hand[last].Color == "null")
                {
                    Destroy(Field.GetChild(0).gameObject);
                    Destroy(whose.GetChild(last).gameObject);

                    EffectBot(hand[last]);

                    Game.Discard.Add(hand[last]);
                    hand.RemoveAt(last);
                    can = true;
                    break;
                }
            }
        }
        ChangeTurn();
    }

    private void Effect()
    {
        Card card = GetCardOnBoard();

        if (card.Number == 10) Draw2 = true;
        else if (card.Number == 11) Revers = !Revers;
        else if (card.Number == 12) Skip = true;
        else if (card.Number == 13) Choose = true;
        else if (card.Number == 14) { Skip = true; Draw4 = true; Choose = true; }
    }

    private void EffectBot(Card card)
    {
        if (card.Number == 10) Draw2 = true;
        else if (card.Number == 11) Revers = !Revers;
        else if (card.Number == 12) Skip = true;
        else if (card.Number == 13) BotChoose = true;
        else if (card.Number == 14) { Skip = true; Draw4 = true; BotChoose = true; }
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

    //Function that looks for ID of dropped card in player deck
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

    //Function foe debug only
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

    public Transform GetPlayerByTurn(int turn)
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
            default:
                return Game.Player;
        }
    }

    public void SetBlue() { ChooseBlue = true; }
    public void SetRed() { ChooseRed = true; }
    public void SetGreen() { ChooseGreen = true; }
    public void SetYellow() { ChooseYellow = true; }

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
