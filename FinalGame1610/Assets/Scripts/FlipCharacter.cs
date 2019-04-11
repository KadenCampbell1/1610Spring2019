using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipCharacter : MonoBehaviour
{
    public bool spriteFlipped;

    public void SpriteFlipEvent()
    {
        spriteFlipped = !spriteFlipped;
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (spriteFlipped)
        {
            transform.Rotate(0,180,0);
            spriteFlipped = false;
        }

        if (!spriteFlipped)
        {
            transform.Rotate(180,0,180);
            spriteFlipped = true;
        }
        
    }
}
