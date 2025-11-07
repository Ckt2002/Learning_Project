using UnityEngine;

public class ER2D_PlayerController : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb2d;
    [SerializeField] float jumpForce;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            rb2d.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }
}
