using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Card
{
    public int Number;
    public string Color;
    public Sprite Logo;
    public bool Draw2;
    public bool Draw4;
    public bool Revers;
    public bool Skip;
    public bool Choose;

/*    public Card(int number, string color, string logo) : this()
    {
        Number = number;
        Color = color;
        Logo = Resources.Load<Sprite>(logo);
    }*/

    public Card(int number, string color, bool draw2, bool revers, bool skip, bool draw4, bool choose, string logo)
    {
        Number = number;
        Color = color;
        Draw2 = draw2;
        Revers = revers;
        Skip = skip;
        Draw4 = draw4;
        Choose = choose;
        Logo = Resources.Load<Sprite>(logo);
    }
}

public static class Game
{
    public static List<Card> Decks = new List<Card>();
}

public class Deck : MonoBehaviour
{
    void Awake()
    {
        Game.Decks.Add(new Card(0, "red", false, false, false, false, false, "Assets/Sprites/Test/Card2"));
        Game.Decks.Add(new Card(0, "red", false, false, false, false, false, "Assets/Sprites/Test/Card2"));
        Game.Decks.Add(new Card(0, "red", false, false, false, false, false, "Assets/Sprites/Test/Card2"));
        Game.Decks.Add(new Card(0, "red", false, false, false, false, false, "Assets/Sprites/Test/Card2"));
        Game.Decks.Add(new Card(0, "red", false, false, false, false, false, "Assets/Sprites/Test/Card2"));
        Game.Decks.Add(new Card(0, "red", false, false, false, false, false, "Assets/Sprites/Test/Card2"));
        Game.Decks.Add(new Card(0, "red", false, false, false, false, false, "Assets/Sprites/Test/Card2"));
    }


}
