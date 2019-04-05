using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackCharacter : MonoBehaviour
{
    public void TrackPlayer(GameObject playerVector3)
    {
        gameObject.transform.position = new Vector3(playerVector3.transform.position.x, playerVector3.transform.position.y, playerVector3.transform.position.z);
    }
}
