using UnityEngine;

public class CS_PlayerGroundedState : CS_PlayerBaseState
{
    public CS_PlayerGroundedState(CS_StatePlayer player, CS_PlayerStateMachine stateMachine) : base(player, stateMachine)
    {
    }

    public override void Execute()
    {
        ApplyMovement(player.walkSpeed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            stateMachine.ChangeState(player.jumpState);
        }

        if (Input.GetMouseButtonDown(0))
        {
            stateMachine.ChangeState(player.attackState);
        }
    }
}