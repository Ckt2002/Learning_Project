using UnityEngine;

public class CS_MoveState : CS_PlayerGroundedState
{
    public CS_MoveState(CS_StatePlayer player, CS_PlayerStateMachine stateMachine) : base(player, stateMachine)
    {
    }

    public override void Enter()
    {
        Debug.Log("Enter Move State!");
    }

    public override void Execute()
    {
        base.Execute();
    }
}