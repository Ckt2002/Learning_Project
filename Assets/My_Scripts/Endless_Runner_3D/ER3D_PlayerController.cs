using UnityEngine;

public class ER3D_PlayerController : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float jumpForce = 5;
    [SerializeField] float rotateSpeed;

    bool isJumping = false;
    Quaternion targetRotate;

    private void Start()
    {
        targetRotate = transform.rotation;
    }

    private void Update()
    {
        //isJumping = rb.velocity.y != 0;

        //if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        //    rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

        if (Input.GetKeyDown(KeyCode.A))
            targetRotate *= Quaternion.Euler(0, 90, 0);
        else if (Input.GetKeyDown(KeyCode.D))
            targetRotate *= Quaternion.Euler(0, -90, 0);

        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotate, Time.deltaTime * rotateSpeed);
    }
}
