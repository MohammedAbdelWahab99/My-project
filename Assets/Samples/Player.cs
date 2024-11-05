using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    public string playerName;
    public int health;
    public static int playerCount = 0;

            // player 

    public void InitializePlayer(string name, int initialHealth)
    {                           
       playerName = name;
       health = initialHealth;

       playerCount++;
    }

            //Health Method

 
    public void Health(int amount)
    {
        health += amount;
    }
    public int ShowHealth()
    {
        return health;
    }
    public void Health(bool fullRestore)
    {
        if (fullRestore)
        {
            health = 100;
        }
    } 


    public static int ShowPlayerCount()
    {
        return playerCount;
    }
}