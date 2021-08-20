using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace BerserkAdventure
{
    public enum GameState 
    {
        MaimMenu,
        Settings,
        Pause,
        Game,
        Win,
        Lose
    }

    public enum InteractibleObjectType
    { 
        PickUp,
        Push,
        Pull,
        Clean
    }
}
