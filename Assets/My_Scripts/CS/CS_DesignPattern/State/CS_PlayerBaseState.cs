using UnityEngine;

public class CS_PlayerBaseState : CS_IPlayerState
{
    protected CS_StatePlayer player;
    protected CS_PlayerStateMachine stateMachine;

    public CS_PlayerBaseState(CS_StatePlayer player, CS_PlayerStateMachine stateMachine)
    {
        this.player = player;
        this.stateMachine = stateMachine;
    }

    public virtual void Enter()
    {
    }

    public virtual void Execute()
    {
    }

    public virtual void Exit()
    {
    }

    protected void ApplyMovement(float moveSpeed)
    {
        float x = Input.GetAxis("Horizontal");
        player.transform.Translate(Vector3.right * x * moveSpeed * Time.deltaTime);
    }
}