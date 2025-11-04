using TMPro;
using UnityEngine;

public class B_ScoreUI : MonoBehaviour
{
    [SerializeField] TMP_Text txtScore;

    public void UpdateUI(int score)
    {
        txtScore.text = score.ToString();
    }
}