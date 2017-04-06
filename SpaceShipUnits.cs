using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

// Base class for all spaceship units in the game.

public abstract class SpaceShipUnits 
{
    public int HitPoints;
    public int AttackRange;
    public int AttackFactor;
    public int DefenceFactor;
    public int MovementPoints;
    public int ActionPoints;

    // Indicates the player that the unit belongs to
    public int PlayerNumber;

}
