using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class MovingToForeGround : MonoBehaviour
{
    public Transform playerTransform;    
    public Vector3 playerScale;
    public bool movingForward;
    
    void Start()
    {
        playerScale = playerTransform.localScale;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (movingForward)
        {
            ScaleIncreaser(playerScale.x);
            ScaleIncreaser(playerScale.y);
        }
        else
        {
            ScaleDecreaser(playerScale.x);
            ScaleDecreaser(playerScale.y);
        }
        
    }

    private float ScaleIncreaser(float scaleUp)
    {
        return scaleUp++;
    }

    private float ScaleDecreaser(float scaleDown)
    {
        return scaleDown--;
    }
}
