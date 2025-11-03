using System;
using UnityEngine;

[Serializable]
public struct PlayerStats
{
    public float moveSpeed;
    public float mouseSensitivity;
}

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] PlayerStats playerStats;
    [SerializeField] Transform playerCamera;
    float xRotation = 0f;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = true;
    }

    void Update()
    {
        HandleLooking();
        HandleMovement();
    }

    private void HandleLooking()
    {
        float mouseX = Input.GetAxis("Mouse X") * playerStats.mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * playerStats.mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -30f, 45f);

        playerCamera.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        transform.Rotate(Vector3.up * mouseX);
    }

    private void HandleMovement()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        Vector3 direction = transform.right * x + transform.forward * z;

        transform.position += direction * playerStats.moveSpeed * Time.deltaTime;
    }
}
