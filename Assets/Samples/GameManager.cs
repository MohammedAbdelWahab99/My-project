using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        Player playerOne = new Player(); //Obiect1
        Player playerTow = new Player(); //Object2
        
        playerOne.InitializePlayer("zodice", 50);
        playerTow.InitializePlayer("Jeffrey", 80);

        playerOne.Health(40);
        playerTow.Health(10);
        Debug.Log(playerOne.health);
        Debug.Log(playerTow.health);

        playerOne.Health(true);
        Debug.Log(playerOne.health);
        
        Debug.Log(Player.ShowPlayerCount());
    }

}
