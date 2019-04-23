using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterFlip : MonoBehaviour
{
//    public GameObject punchObj;
//    public GameObject defObj;
    public GameObject playerAnimSprites;
    public bool canFlipPunch;
    // Start is called before the first frame update
    void Start()
    {
        canFlipPunch = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("x"))
        {
            if (canFlipPunch)
            {
                //punchObj.transform.Rotate(0,180,0);
                //defObj.transform.Rotate(0,180,0);
                playerAnimSprites.transform.Rotate(0,180,0);
                canFlipPunch = false;
            }
        }

        if (Input.GetKeyDown("c"))
        {
            if (!canFlipPunch)
            {
                //punchObj.transform.Rotate(0, 180, 0);
                //defObj.transform.Rotate(0,180,0);
                playerAnimSprites.transform.Rotate(0,180,0);
                canFlipPunch = true;
            }
        }
    }
}
