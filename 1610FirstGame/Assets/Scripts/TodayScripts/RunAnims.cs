using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunAnims : MonoBehaviour
{
    private Animator anims;
    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        anims = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anims.SetFloat("Speed", speed);
        
        //replacing speed with
        //CharacterController.velocity
        //floatData.Value
    }
}
