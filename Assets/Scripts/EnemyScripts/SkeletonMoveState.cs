using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonMoveState : SkeletonGroundedState
{
    public SkeletonMoveState(Enemy _enemyBase, EnemyStateMachine _stateMachine, string _aniBoolName, Enemy_Skeleton enemy) : base(_enemyBase, _stateMachine, _aniBoolName, enemy)
    {

    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void Update()
    {
        base.Update();
        enemy.SetVelocity(enemy.moveSpeed * enemy.facingDirection, rb.velocity.y);
        if(enemy.IsWallDetected() || !enemy.IsGroundDetected())
        {           
            enemy.stateMachine.ChangeState(enemy.idleState);
            enemy.Flip();
        }
    }
}
