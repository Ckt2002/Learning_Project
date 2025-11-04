using System.Collections;
using UnityEngine;

public class CTB_GameController : MonoBehaviour
{
    public static CTB_GameController instance;

    [SerializeField] CTB_UIScoreController uIScore;
    [SerializeField] float spawnTimeATurn = 0.2f;
    [SerializeField] float waitTimeATurn = 3f;

    int spawnNumber = 1;
    int currentScore = 0;
    CTB_BallsController ballsController;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(this);
    }

    private void Start()
    {
        ballsController = CTB_BallsController.instance;
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