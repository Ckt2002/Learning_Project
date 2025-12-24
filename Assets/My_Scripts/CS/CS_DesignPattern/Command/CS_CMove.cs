
using UnityEngine;

public class CS_CMove : CS_ICommand
{
    private Transform playerTransform;
    private Vector3 direction;
    private float moveSpeed;

    public CS_CMove(Transform player, Vector3 direction, float moveSpeed)
    {
        playerTransform = player;
        this.direction = direction;
        this.moveSpeed = moveSpeed;
    }

    public void Execute()
    {
        playerTransform.position += direction * moveSpeed;
    }

    public void Undo()
    {
        playerTransform.position -= direction * moveSpeed;
    }
}