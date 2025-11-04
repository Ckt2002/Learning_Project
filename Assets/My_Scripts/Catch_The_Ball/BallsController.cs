using System.Collections.Generic;
using UnityEngine;

public class BallsController : MonoBehaviour
{
    public static BallsController instance;

    [SerializeField] float ballMoveSpeed;
    [SerializeField] float fromXPos;
    [SerializeField] float toXPos;

    Vector3 direction;
    List<GameObject> gottenBalls;
    BallPooling ballPooling;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            gottenBalls = new();
            direction = Vector3.down.normalized;
        }
        else
            Destroy(this);
    }

    private void Start()
    {
        ballPooling = BallPooling.instance;
    }

    void Update()
    {
        foreach (GameObject ball in gottenBalls)
        {
            ball.transform.position += direction * Time.deltaTime * ballMoveSpeed;
        }
    }

    public void SpawnBall()
    {
        gottenBalls.Add(ballPooling.GetBall(
            new Vector3(Random.Range(fromXPos, toXPos + 1), 6)
            ));
    }

    public void ReturnBall(GameObject ball)
    {
        gottenBalls.Remove(ball);
        ballPooling.ReturnBall(ball);
    }

    public void IncreaseMoveSpeed()
    {
        ballMoveSpeed += 0.5f;
    }
}