using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipCharacter : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        transform.Rotate(0, 180, 0);
    }
}
