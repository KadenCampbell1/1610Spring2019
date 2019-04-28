using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Integrated from School Lessons
public class CharacterFlip : MonoBehaviour
{
    public GameObject playerAnimSprites;
    public bool canFlipPunch;
    
    void Start()
    {
        canFlipPunch = true;
    }

    
    void Update()
    {
        if (Input.GetKeyDown("x"))
        {
            if (canFlipPunch)
            {
                playerAnimSprites.transform.Rotate(0,180,0);
                canFlipPunch = false;
            }
        }

        if (Input.GetKeyDown("c"))
        {
            if (!canFlipPunch)
            {
                playerAnimSprites.transform.Rotate(0,180,0);
                canFlipPunch = true;
            }
        }
    }
}
