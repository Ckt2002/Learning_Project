using UnityEngine;

public class B_BallController : MonoBehaviour
{
    [SerializeField] float moveSpeed;

    B_GameController gameController;
    Vector2 direction = new Vector2(0.1f, 1).normalized;
    int brickLayer;
    int playerLayer;

    private void Start()
    {
        gameController = B_GameController.instance;
        brickLayer = LayerMask.NameToLayer("Target");
        playerLayer = LayerMask.NameToLayer("Player");
    }

    void Update()
    {
        transform.Translate(moveSpeed * direction * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 normal = collision.contacts[0].normal;
        direction = Vector2.Reflect(direction, normal);

        if (collision.gameObject.layer == brickLayer)
        {
            gameController.IncreaseScore();
            collision.gameObject.SetActive(false);
            return;
        }

        if (collision.gameObject.layer == playerLayer && direction.y < 0)
            direction.y = Mathf.Abs(direction.y);
    }
}