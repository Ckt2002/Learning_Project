using UnityEngine;

public class CS_StatePlayer : MonoBehaviour
{
    public float walkSpeed = 5f;

    private CS_PlayerStateMachine stateMachine;

    public CS_IPlayerState attackState { get; private set; }
    public CS_IPlayerState jumpState { get; private set; }
    public CS_IPlayerState idleState { get; private set; }
    public CS_IPlayerState moveState { get; private set; }

    private void Awake()
    {
        stateMachine = new CS_PlayerStateMachine();

        attackState = new CS_AttackState(this, stateMachine);
        jumpState = new CS_JumpState(this, stateMachine);
        idleState = new CS_IdleState(this, stateMachine);
        moveState = new CS_MoveState(this, stateMachine);

        stateMachine.Initialize(idleState);
    }

    private void Update()
    {
        stateMachine.playerCurrentState.Execute();

        if (Input.GetKeyDown(KeyCode.T))
        {
            Debug.Log("Current State: " + stateMachine.playerCurrentState.GetType().Name);
        }
    }
}