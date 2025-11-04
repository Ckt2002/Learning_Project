using UnityEngine;

public class B_PanelController : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] float maxXPos;
    [SerializeField] float minXPos;
    Vector3 direction = Vector3.right.normalized;

    private void Update()
    {
        if (!Input.GetButton("Horizontal"))
            return;

        float input = Input.GetAxisRaw("Horizontal");

        if (transform.position.x >= maxXPos && input == 1 ||
            transform.position.x <= minXPos && input == -1)
            return;

        Vector3 currentDirection = input * direction;
        transform.position += currentDirection * Time.deltaTime * moveSpeed;
    }
}
