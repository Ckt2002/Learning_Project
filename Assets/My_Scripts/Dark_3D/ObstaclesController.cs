using UnityEngine;

public class ObstaclesController : MonoBehaviour
{
    [SerializeField] Transform[] obstacles;
    [SerializeField] float rotateSpeed;

    void Update()
    {
        foreach (Transform obstacle in obstacles)
        {
            float yRotation = rotateSpeed * Time.deltaTime;
            obstacle.localRotation *= Quaternion.Euler(0f, yRotation, 0f);
        }
    }
}
