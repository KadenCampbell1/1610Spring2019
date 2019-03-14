using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

[CreateAssetMenu]
public class DnDCharacterData : ScriptableObject
{
    //make a counter that runs through a while loop to roll multiple dice
    public int numberOfDiceRolled;
    //check if value was 20
    public int valueOfDiceRolled;
    //attack bonus and check bonuses
    public int bonusValue;
    //strength mod plus weapon bonus (+str+2 for gravedigger)
    public int damageBonus;
    //values to make damageBonus
    public int strMod, weaponBonus;
    //highest spell slot level to set up array
    public int spellSlotMax;
    public int[] spellSlots;
    public int useSpellSlot;
    public int auraOfHateValue;
    public bool withinAuraOfHate;
}
