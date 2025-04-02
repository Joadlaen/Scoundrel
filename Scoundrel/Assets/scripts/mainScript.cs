using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        System.Random PRand = new System.Random();
        string[,] Dungeon1 = new string[4,13];
        string[] Names = new string[13] { "2", "3", "4", "5", "6", "7", "8", "9", "0", "j", "q", "k", "a"};
        string[] Suits = new string[4] { "hearts", "spades", "diamonds", "clubs"};
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 13; j++)
            {
                Dungeon1[i, j] = ($"{Suits[i]}{Names[j]}");
            }
        }
        //hearts for health refills, diamonds for weapons, spades for base damage, clubs for double damage if no health potion was used.
        string[] dungeonShuffle = new string[26];
        for (int i = 0;i < 26; i++)
        {
            string randomName = Names[PRand.Next(Names.Length)];
            string randomSuit = Suits[PRand.Next(Suits.Length)];
            dungeonShuffle[i] = $"{randomSuit}{randomName}";
        }
        Debug.Log("hello");
        Debug.Log(dungeonShuffle[1]);
        Console.WriteLine(dungeonShuffle);






    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
