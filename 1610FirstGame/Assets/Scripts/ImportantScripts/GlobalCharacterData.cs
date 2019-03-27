using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class GlobalCharacterData : ScriptableObject
{
    public int playerHealth;
    public int playerSpeed;
    public int playerArmor;
    public int playerPower;
    public int playerJumpHeight;
    public float playerBlockDistance;
    
    private void OnEnable()
    {
        playerHealth = 100;
        playerArmor = 0;
        playerSpeed = 15;
        playerJumpHeight = 5;
        playerBlockDistance = 5;
        playerPower = 5;
    }
}
