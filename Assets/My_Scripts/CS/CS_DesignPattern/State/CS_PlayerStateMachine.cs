public class CS_PlayerStateMachine
{
    public CS_IPlayerState playerCurrentState { get; private set; }

    public void Initialize(CS_IPlayerState startingState)
    {
        playerCurrentState = startingState;
        playerCurrentState.Enter();
    }

    public void ChangeState(CS_IPlayerState newState)
    {
        playerCurrentState.Exit();
        playerCurrentState = newState;
        playerCurrentState.Enter();
    }
}