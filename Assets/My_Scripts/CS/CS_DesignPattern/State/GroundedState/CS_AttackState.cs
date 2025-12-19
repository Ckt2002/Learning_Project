using UnityEngine;

public class CS_AttackState : CS_PlayerGroundedState
{
    public CS_AttackState(CS_StatePlayer player, CS_PlayerStateMachine stateMachine) : base(player, stateMachine)
    {
    }

    public override void Enter()
    {
        Debug.Log("Entering Attack State!");
    }

    public override void Execute()
    {
        base.Execute();
    }
}