using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Ship;

public class ShipDirector
{
    public Ship BuildShip(ShipType type)
    {
        var builder = new ShipBuilder();
        switch(type)
        {
            case ShipType.Brigantine:
                builder.SetSail(true)
                    .SetCapacity(10)
                    .SetMoves(22)
                    .SetPower(10, 2.2f);
                break;
            case ShipType.Lincore:
                builder.SetSail(true)
                    .SetCapacity(12)
                    .SetMoves(20)
                    .SetPower(8, 2.2f);
                break;
            case ShipType.Frigate:
                builder.SetSail(true)
                    .SetCapacity(16)
                    .SetMoves(26)
                    .SetPower(20);
                break;
            case ShipType.Galleone:
                builder.SetSail(true)
                    .SetCapacity(32)
                    .SetMoves(18)
                    .SetPower(12, 3.1f);
                break;
            default:
                builder.SetSail(false)
                    .SetCapacity(5)
                    .SetMoves(15)
                    .SetPower(10, 1.4f);
                break;
        }
        return builder.Build();
    }
}
