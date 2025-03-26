using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
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
        //hearts for health refills, diamonds for weapons, spades for base damage, clubs for (div 5 - 1) * 5 or base damage

        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
