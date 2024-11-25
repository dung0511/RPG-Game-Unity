using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrimeAttackState : PlayerState
{
    private int comboCounter;
    private float lastTimeAttacked;
    private float comboWindow = 2;
    public PlayerPrimeAttackState(Player _player, PlayerStateMachine _stateMachine, string _animBoolName) : base(_player, _stateMachine, _animBoolName)
    {

    }

    public override void Enter()
    {

        AudioManagerScript.instance.PlaySFX(1);
        base.Enter();
        //xInput = 0;
        if(comboCounter > 2 || Time.time > lastTimeAttacked + comboWindow)
        {
            comboCounter = 0;
        }
        player.animator.SetInteger("ComboCounter", comboCounter);
        float attackDirection = player.facingDirection;
        if(xInput != 0)
        {
            attackDirection = xInput;
        }
        player.SetVelocity(player.attackMovement[comboCounter].x * attackDirection, player.attackMovement[comboCounter].y);
        stateTimer = .1f;
    }

    public override void Exit()
    {
        base.Exit();
        comboCounter++;
        lastTimeAttacked = Time.time;
        player.StartCoroutine("BusyFor", .15f);
    }

    public override void Update()
    {
        base.Update();
        if(stateTimer < 0)
        {
            player.SetZeroVelocity();
        }
        if(triggerCalled)
        {
            stateMachine.ChangeState(player.idleState);
        }
    }
}
