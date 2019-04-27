using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss2Battle : MonoBehaviour
{
    public float waitTime = 1;
    private int incrementor = 5;
    public GameObject enemySpawn;
    
    
    public void StartBossCounter()
    {
        StartCoroutine(RunBossCounter());
    }

    private IEnumerator RunBossCounter()
    {
        var waitObj = new WaitForSeconds(waitTime);

        for (int i = 0; i < incrementor; i++)
        {
            yield return waitObj;
            incrementor++;
            Instantiate(enemySpawn, new Vector3(1.81f + gameObject.transform.position.x, -8.9f + gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.identity);
        }

        yield return waitObj;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
