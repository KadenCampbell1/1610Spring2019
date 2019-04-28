using System.Collections;
using System.Collections.Generic;
using ScriptableObjectScripts;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

//Integrated from School Lessons and Unity's Web page
public class LivesEvents : MonoBehaviour
{
    public FloatSobjData myLives;

    public UnityEvent DeathEvent;
    
    void Update()
    {
        if (myLives.Value <= 0)
        {
            DeathEvent.Invoke();
        }
    }

    public void Restart(string myScene)
    {
        SceneManager.LoadScene(myScene);
    }
}
