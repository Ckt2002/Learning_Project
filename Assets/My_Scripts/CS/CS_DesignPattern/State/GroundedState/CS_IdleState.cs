using UnityEngine;

public class CS_IdleState : CS_PlayerGroundedState
{
    public CS_IdleState(CS_StatePlayer player, CS_PlayerStateMachine stateMachine) : base(player, stateMachine)
    {
    }

    public override void Enter()
    {
        Debug.Log("Entering Idle State");
    }

    public override void Execute()
    {
        base.Execute();
    }
}