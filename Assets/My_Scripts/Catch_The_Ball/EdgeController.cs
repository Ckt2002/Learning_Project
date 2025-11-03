using UnityEngine;

public class EdgeController : MonoBehaviour
{
    BallPooling ballPooling;
    BallsController ballsController;

    private void Start()
    {
        ballPooling = BallPooling.instance;
        ballsController = BallsController.instance;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        // ballPooling.ReturnBall(collision.gameObject);
        ballsController.ReturnBall(collision.gameObject);
    }
}