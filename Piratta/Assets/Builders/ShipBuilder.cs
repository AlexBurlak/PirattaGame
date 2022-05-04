using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipBuilder
{
    private Ship _ship;
    public ShipBuilder()
    {
        _ship = new Ship();
    }
    
    public ShipBuilder SetCapacity(ushort capacity)
    {
        _ship.CurrentCapacity = 0;
        _ship.MaxCapacity = capacity;
        return this;
    }

    public ShipBuilder SetMoves(int maxMoves)
    {
        _ship.MovedTiles = 0;
        _ship.DayMoves = maxMoves;
        return this;
    }

    public ShipBuilder SetSail(bool hasSail)
    {
        _ship.HasSail = hasSail;
        return this;
    }

    public ShipBuilder SetPower(int initialPower, float modifier = 1f)
    {
        _ship.Power = Mathf.RoundToInt(initialPower * modifier);
        return this;
    }

    public Ship Build()
    {
        return _ship;
    }
}
