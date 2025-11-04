using UnityEngine;

public class CTB_EdgeController : MonoBehaviour
{
    CTB_BallPooling ballPooling;
    CTB_BallsController ballsController;

    private void Start()
    {
        ballPooling = CTB_BallPooling.instance;
        ballsController = CTB_BallsController.instance;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        // ballPooling.ReturnBall(collision.gameObject);
        ballsController.ReturnBall(collision.gameObject);
    }
}