using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System;

// Game class keeps track of the game, units and players objects. It starts the game and makes turn transitions. 

public class Game : MonoBehaviour
{
    public event EventHandler GameStarted;
    public event EventHandler GameEnded;
    public event EventHandler TurnEnded;

    public List<Cell> Cells { get; private set; }

    void Start()
    {
        Cells = new List<Cell>();
        for (int i = 0; i < transform.childCount; i++)
        {
            var cell = transform.GetChild(i).gameObject.GetComponent<Cell>();
            if (cell != null)
                Cells.Add(cell);
            else
                Debug.LogError("Invalid object in cell");
        }
    }

    public void StartGame()
    {
    }

    public void EndTurn()
    {
    }
}
