using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals : MonoBehaviour
{
    public bool canWalk;
    public int number = 11;
    public string password;
    
    // Update is called once per frame
    void Update()
    {
        if (canWalk)
        {
            print("True");
        }
        else
        {
            print("False");
        }

        if (number >= 10)
        {
            print("greater");
        }
        else
        {
            print("less");
        }

        if (password == "Images")
        {
            print("and Words");
        }
        else
        {
            print("Over Time");
        }
        
    }
}
