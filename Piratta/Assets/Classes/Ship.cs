using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship
{
    public enum ShipType
    {
        Lincore = 0,
        Galleone = 1,
        Frigate = 2,
        Brigantine = 3
    }
    public ushort MaxCapacity { get; set; }
    public int DayMoves { get; set; }
    public int MovedTiles { get; set; }
    public ushort CurrentCapacity { get; set; }
    public int Power { get; set; }
    public bool HasSail { get; set; }
    public Ship()
    {

    }
}
