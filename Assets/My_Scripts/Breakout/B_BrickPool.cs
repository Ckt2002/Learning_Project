using UnityEngine;

public class B_BrickPool : MonoBehaviour
{
    [SerializeField] GameObject brickPrefab;
    [SerializeField] Vector2 startSpawnPos = new Vector2();
    [SerializeField] float spawnPosOffsetX;
    [SerializeField] float spawnPosOffsetY;
    [SerializeField] int spawnNumberX;
    [SerializeField] int spawnNumberY;
    [SerializeField] Transform bricksParent;

    private void Start()
    {
        Vector2 spawnPos = startSpawnPos;

        for (int y = 0; y < spawnNumberY; y++)
        {
            spawnPos.y = startSpawnPos.y + y * spawnPosOffsetY;
            spawnPos.x = startSpawnPos.x;
            for (int x = 0; x < spawnNumberX; x++)
            {
                spawnPos.x = startSpawnPos.x + x * spawnPosOffsetX;
                GameObject brick = Instantiate(brickPrefab, bricksParent);
                brick.transform.position = spawnPos;
            }
        }
    }
}