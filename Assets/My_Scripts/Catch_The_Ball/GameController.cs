using System.Collections;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController instance;

    [SerializeField] UIScoreController uIScore;

    int spawnNumber = 1;
    int currentScore = 0;
    BallsController ballsController;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
            Destroy(this);
    }

    private void Start()
    {
        ballsController = BallsController.instance;
        StartCoroutine(SpawnBall());
    }

    private IEnumerator SpawnBall()
    {
        while (true)
        {
            for (int i = 0; i < spawnNumber; i++)
            {
                ballsController.SpawnBall();
                yield return new WaitForSeconds(0.2f);
            }
            yield return new WaitForSeconds(3f);
        }
    }

    public void UpdateScore()
    {
        currentScore++;
        uIScore.UpdateUI(currentScore);
    }
}