﻿using ImportantScripts;
using UnityEngine;

namespace DailyScripts
{
    [CreateAssetMenu]
    public class ShieldInheriting : PowerUpBase
    {
        private void OnEnable()
        {
            gloabalPowerUpValue = 50;
        }


        public void ShieldDamage()
        {
            gloabalPowerUpValue -= 10;
        
            if (gloabalPowerUpValue <= 0)
            {
                //print you have no shields
            }
            else
            {
                //print shield total
            }
        }
    }
}
