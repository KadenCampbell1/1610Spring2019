using ImportantScripts;
using UnityEngine;

namespace DailyScripts
{
    [CreateAssetMenu]
    public class AttackInheriting : PowerUpBase
    {
        private void OnEnable()
        {
            gloabalPowerUpValue = 5;
        }

        public void DoDamage()
        {
            //take away from shield
            //if (ShieldInheriting <= 0)
            {
                //take away from health
                //if (HealthInheriting <= 0)
                {
                    //print you are dead
                }
            }
        }
    }
}
