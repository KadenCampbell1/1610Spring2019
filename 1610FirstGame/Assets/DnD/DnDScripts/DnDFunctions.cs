using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class DnDFunctions : DnDCharacterData
{
    private int RollDie()
    {
        //print Dice Roll:
        return Random.Range(1, valueOfDiceRolled);
    }

    private int AddBonusValue()
    {
        //print Check Value:
        return RollDie() + bonusValue;
    }

    private int DamageDealt()
    {
        //make array variable that is numberOfDiceRolled long to keep track of the values then add them together here plus damageBonus
        damageBonus = strMod + weaponBonus;
        if (withinAuraOfHate)
        {
            damageBonus += auraOfHateValue;
        }
        return +damageBonus;
    }
}
