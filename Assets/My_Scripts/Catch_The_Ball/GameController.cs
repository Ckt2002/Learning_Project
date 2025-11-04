using System.Collections;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController instance;

    [SerializeField] UIScoreController uIScore;
    [SerializeField] float spawnTimeATurn = 0.2f;
    [SerializeField] float waitTimeATurn = 3f;

    int spawnNumber = 1;
    int currentScore = 0;
    BallsController ballsController;

    private void Awake()
    {
        if (instance == null)
            instance = this;
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
            if (currentScore > 0 && currentScore % 10 == 0)
            {
                spawnNumber++;
                ballsController.IncreaseMoveSpeed();
            }

            for (int i = 0; i < spawnNumber; i++)
            {
                ballsController.SpawnBall();
                yield return new WaitForSeconds(spawnTimeATurn);
            }

            yield return new WaitForSeconds(waitTimeATurn);
        }
    }

    public void UpdateScore()
    {
        currentScore++;
        uIScore.UpdateUI(currentScore);
    }
}