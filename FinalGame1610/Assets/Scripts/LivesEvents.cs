using System.Collections;
using System.Collections.Generic;
using ScriptableObjectScripts;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class LivesEvents : MonoBehaviour
{
    public FloatSobjData myLives;

    public UnityEvent DeathEvent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
