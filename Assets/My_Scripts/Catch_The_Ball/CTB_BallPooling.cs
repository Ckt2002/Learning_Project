using System.Collections.Generic;
using UnityEngine;

public class CTB_BallPooling : MonoBehaviour
{
    public static CTB_BallPooling instance;

    [SerializeField] GameObject ballPrefab;
    [SerializeField] int spawnNumber = 10;
    [SerializeField] Transform ballParent;

    Queue<GameObject> spawnedBalls;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            spawnedBalls = new();
        }
        else
            Destroy(this);
    }

    private void Start()
    {
        for (int i = 0; i < spawnNumber; i++)
        {
            GameObject ball = Instantiate(ballPrefab, ballParent);
            spawnedBalls.Enqueue(ball);
            ball.SetActive(false);
        }
    }

    public GameObject GetBall(Vector3 startPosition)
    {
        if (spawnedBalls.Count > 0)
        {
            GameObject ball = spawnedBalls.Dequeue();
            ball.transform.position = startPosition;
            ball.SetActive(true);
            return ball;
        }

        GameObject newBall = Instantiate(ballPrefab, ballParent);
        newBall.transform.position = startPosition;
        return newBall;
    }

    public void ReturnBall(GameObject ball)
    {
        ball.SetActive(false);
        spawnedBalls.Enqueue(ball);
    }
}