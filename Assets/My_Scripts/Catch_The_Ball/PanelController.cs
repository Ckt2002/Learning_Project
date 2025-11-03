using System;
using UnityEngine;

[Serializable]
public struct PanelData
{
    public float moveSpeed;
    public float maxXPos;
    public float minXPos;
}

public class PanelController : MonoBehaviour
{
    [SerializeField] PanelData panelData;
    Vector3 direction = Vector3.right.normalized;
    BallsController ballsController;
    GameController gameController;

    private void Start()
    {
        ballsController = BallsController.instance;
        gameController = GameController.instance;
    }

    private void Update()
    {
        if (!Input.GetButton("Horizontal"))
            return;

        float input = Input.GetAxisRaw("Horizontal");

        if (transform.position.x >= panelData.maxXPos && input == 1 ||
            transform.position.x <= panelData.minXPos && input == -1)
            return;

        Vector3 currentDirection = input * direction;
        transform.position += currentDirection * Time.deltaTime * panelData.moveSpeed;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        ballsController.ReturnBall(collision.gameObject);
        gameController.UpdateScore();
    }
}
