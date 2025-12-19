using UnityEngine;

public class CS_JumpState : CS_PlayerAirborneState
{
    public CS_JumpState(CS_StatePlayer player, CS_PlayerStateMachine stateMachine) : base(player, stateMachine)
    {
    }

    public override void Enter()
    {
        Debug.Log("Entering Jump State!");
    }

    public override void Execute()
    {
        base.Execute();
    }
}