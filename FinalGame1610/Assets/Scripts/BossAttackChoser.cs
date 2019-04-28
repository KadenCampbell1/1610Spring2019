using System;
using System.Collections;
using System.Collections.Generic;
using ScriptableObjectScripts;
using UnityEngine;
using Random = System.Random;

//Integrated from School
public class BossAttackChoser : MonoBehaviour
{
    public Animator bossAnimator;
    public float waitTime = 1;
    public int rngBossNum;
    private int incrementor = 5;
    
    
    void Start()
    {
        bossAnimator = GetComponent<Animator>();
        StartBossCounter();
    }

    public enum AttackChoice
    {
        Idle,
        Attack,
        Sweep
    }

    public AttackChoice bossAttack;
    
    
    void Update()
    {
        if (rngBossNum == 0)
        {
            bossAttack = AttackChoice.Idle;
        } 
        else if (rngBossNum == 1)
        {
            bossAttack = AttackChoice.Attack;
        }
        else
        {
            bossAttack = AttackChoice.Sweep;
        }
        
        switch (bossAttack)
        {
            case AttackChoice.Idle:
                bossAnimator.SetBool("IsIdle", true);
                bossAnimator.SetBool("IsAttack", false);
                bossAnimator.SetBool("IsSweep", false);
                break;
            case AttackChoice.Attack:
                bossAnimator.SetBool("IsIdle", false);
                bossAnimator.SetBool("IsAttack", true);
                bossAnimator.SetBool("IsSweep", false);
                break;
            case AttackChoice.Sweep:
                bossAnimator.SetBool("IsIdle", false);
                bossAnimator.SetBool("IsAttack", false);
                bossAnimator.SetBool("IsSweep", true);
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
    
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
            rngBossNum = UnityEngine.Random.Range(0, 3);
        }

        yield return waitObj;
    }
}
