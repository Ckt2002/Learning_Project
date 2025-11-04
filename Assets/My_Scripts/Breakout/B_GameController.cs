using UnityEngine;

public class B_GameController : MonoBehaviour
{
    public static B_GameController instance;

    int currentScore = 0;
    B_ScoreUI scoreUI;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(this);
    }

    private void Start()
    {
        scoreUI = FindAnyObjectByType<B_ScoreUI>();
    }

    public void IncreaseScore()
    {
        scoreUI.UpdateUI(++currentScore);
    }
}