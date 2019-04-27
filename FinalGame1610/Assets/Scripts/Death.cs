using System.Collections;
using System.Collections.Generic;
using ScriptableObjectScripts;
using UnityEngine;

public class Death : MonoBehaviour
{
    public FloatSobjData healthObj;
    public LivesEvents livesScript = null;
    public bool isPlayer;
    
    void Update()
    {
        if (isPlayer)
        {
            if (healthObj.Value <= 0)
            {
                livesScript.myLives.Value -= 1;
                livesScript.Restart("Scene1");
            }
        }
        else
        {
            if (healthObj.Value <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
