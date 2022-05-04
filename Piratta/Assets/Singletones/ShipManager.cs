using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Ship;

public class ShipManager
{
    public ShipType Type { get; set; }
    public Ship CurrentShip { get; set; }
    private static ShipManager _shipManager;
    public static ShipManager Instance {
        get
        {
            if (_shipManager == null) _shipManager = new ShipManager();
            return _shipManager;
        }
    }
    public void SetType(int i)
    {
        if (i < Enum.GetNames(typeof(ShipType)).Length)
        {
            Type = (ShipType)i;
            var director = new ShipDirector();
            CurrentShip = director.BuildShip(Type);
        }
    }
}
