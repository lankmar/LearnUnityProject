using System;
using System.Collections.Generic;
using UnityEngine;

namespace BerserkAdventure
{
    public class Timer
    {
        //DateTime zero = new DateTime();

        public bool EditTime()
        {
            if (Main.mainGame.timeTrapActivation > 0)
            {
                //Debug.Log("MainGame.mainGame.timeCompleteLevel - "+ MainGame.mainGame.timeCompleteLevel);
                Main.mainGame.timeTrapActivation -= Time.fixedDeltaTime / 3;
                return true;
            }
            if (Main.mainGame.timeTrapActivation < 0)
            {
                Main.mainGame.timerIsActive = false;
            }
            return false;
        }
    }
}
