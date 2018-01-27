//*********************************************************
//
// $created by Cody Stough
// $purpose : This script will manage each "turn" and control things for a game session like score, etc.
// $attach  : attach this to the Game Manager object
//
//*********************************************************

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SessionManager : MonoBehaviour {

    public List<Character> players = new List<Character>();

    public Character currentTurn; //the character whose turn it currently is

    public int maxTurns; //Can setup a game with a maximum turn count
    public bool maxTurnGame; //true if the current session is a max turn count game

    public void Start()
    {
        string[] empNames = {"Russia","Japan" }; //Exmple characters

        NewGame(2, empNames); //Calls the newgame and adds the example characters to the players list
    }

    public void NewGame(int numPlayers, string[] empireNames) //Used for setting up a newgame
    {
        for(int i = 0; i < numPlayers; i++)
        {
            players.Add(new Character(empireNames[i]));
        }
    }

    public void GameTurn() //This function gets called once per player and loops until a game ending state is present
    {
        if (maxTurnGame)
        {
            for (int i = 0; i < maxTurns; i++) //loop finite or until game win state
            {
                //need to call a function that initiates a "turn" for each player in the list. Some kind of function that gives them control
            }
        }
        else
        {
            for(; ;) //loop infinite or until game win state
            {
                //need to call a function that initiates a "turn" for each player in the list. Some kind of function that gives them control
            }
        }
    }

}

public class Character //Character class, this may or may not need to go here, just for ease of reading the code.
{
    public string empireName;
    public int score;

    public Character(string name)
    {
        empireName = name;
        InitPlayer();
        Debug.Log("New player: " + empireName + " Score: " + score);
    }

    public void InitPlayer()
    {
        score = 0;
    }
}
