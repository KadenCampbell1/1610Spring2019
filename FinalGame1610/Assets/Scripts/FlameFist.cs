﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameFist : MonoBehaviour
{
    public GameObject playerBodyObj;
    public Forces forceScript;

    void Update()
    {
        if (playerBodyObj.transform.rotation.y == 180)
        {
            forceScript.forceAmount.x = -forceScript.forceAmount.x;
        }
    }
}
