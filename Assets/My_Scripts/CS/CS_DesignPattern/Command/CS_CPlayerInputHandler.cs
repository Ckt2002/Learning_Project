using UnityEngine;

public class CS_CPlayerInputHandler : MonoBehaviour
{
    public CS_CInvoker invoker;
    public float moveSpeed = 1f;

    private Transform player;

    private void Start()
    {
        player = transform;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            CS_ICommand moveUp = new CS_CMove(player, Vector3.forward, moveSpeed);
            invoker.ExecuteCommand(moveUp);
        }

        if (Input.GetKey(KeyCode.Z))
        {
            invoker.UndoLastCommand();
        }
    }
}