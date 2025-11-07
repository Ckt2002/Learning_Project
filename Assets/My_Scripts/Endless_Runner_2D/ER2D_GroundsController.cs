using System.Collections.Generic;
using UnityEngine;

public class ER2D_GroundsController : MonoBehaviour
{
    [SerializeField] Vector3 groundMoveDirection = Vector3.left;
    [SerializeField] float groundMoveSpeed;
    [SerializeField] float startResetPosDistance;
    [SerializeField] List<GameObject> groundPieces;

    GameObject groundToReset;
    ER2D_PlayerController player;

    private void Awake()
    {
        groundMoveDirection = groundMoveDirection.normalized;
    }

    private void Start()
    {
        player = FindFirstObjectByType<ER2D_PlayerController>();
    }

    private void Update()
    {
        Vector3 playerPos = player.transform.position;

        int index = 0;

        while (index < groundPieces.Count)
        {
            Transform groundTransform = groundPieces[index].transform;

            if (groundTransform.position.x < playerPos.x &&
                Vector3.Distance(groundTransform.position, playerPos) >= startResetPosDistance)
            {
                float resetXPos = groundPieces[groundPieces.Count - 1].transform.position.x
                    + 11;
                groundTransform.position = Vector2.right * resetXPos + Vector2.down * 0.5f;

                groundPieces.Remove(groundTransform.gameObject);
                groundToReset = groundTransform.gameObject;
            }

            groundTransform.position += groundMoveDirection * groundMoveSpeed * Time.deltaTime;
            ++index;
        }

        if (groundToReset != null)
        {
            groundPieces.Add(groundToReset);
            groundToReset = null;
        }
    }
}
