using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Integrated from Unity's web page and school
//not being used
public class TrackCharacter : MonoBehaviour
{
    public EnemyNavAi navAI;
    public void TrackPlayer(GameObject playerVector3)
    {
        navAI.agent.destination = navAI.player.position;
    }
}
