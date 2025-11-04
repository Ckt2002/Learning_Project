using UnityEngine;

public class B_BallController : MonoBehaviour
{
    [SerializeField] float moveSpeed;

    Vector2 direction = new Vector2(0.1f, 1).normalized;

    void Update()
    {
        transform.Translate(moveSpeed * direction * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 normal = collision.contacts[0].normal;
        direction = Vector2.Reflect(direction, normal);

        if (collision.gameObject.name.Equals("Panel") && direction.y < 0)
            direction.y = Mathf.Abs(direction.y);
    }
}