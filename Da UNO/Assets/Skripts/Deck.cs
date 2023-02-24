using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    public string[] id = new string[108];           //position in massive is id, content is path to Sprite of card with this id

    void Awake()
    {
        for (int i = 0; i < 108; i++)
        {
            id[i] = "Assets/Sprites/Test/Card" + i; //initialising cards in deck
        }
    }

    void Start()
    {
    }

    void Update()
    {
        
    }
}
