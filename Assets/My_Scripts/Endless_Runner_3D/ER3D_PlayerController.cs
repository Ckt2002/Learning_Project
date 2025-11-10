using UnityEngine;

public class ER3D_PlayerController : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float jumpForce = 5;

    bool isJumping = false;

    private void Update()
    {
        isJumping = rb.velocity.y != 0;

        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}
