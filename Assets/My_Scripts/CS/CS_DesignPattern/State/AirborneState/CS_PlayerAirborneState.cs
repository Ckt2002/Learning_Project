using UnityEngine;

public class CS_PlayerAirborneState : CS_PlayerBaseState
{
    public CS_PlayerAirborneState(CS_StatePlayer player, CS_PlayerStateMachine stateMachine) : base(player, stateMachine)
    {
    }

    public override void Execute()
    {
        ApplyMovement(player.walkSpeed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            stateMachine.ChangeState(player.idleState);
        }
    }
}