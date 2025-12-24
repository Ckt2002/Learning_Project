using UnityEngine;

public class CS_SPlayer : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;

    private CS_IMoveStrategy currentStrategy;

    private void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector3 inputDir = new Vector3(h, 0, v).normalized;

        if (inputDir.magnitude > 0.1f)
        {
            currentStrategy.Move(transform, inputDir, moveSpeed);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            currentStrategy = new PlayerFlyStrategy();
            Debug.Log("Switched to Flight Mode!");
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            currentStrategy = new PlayerWalkStrategy();
            Debug.Log("Back to Walking.");
        }
    }
}