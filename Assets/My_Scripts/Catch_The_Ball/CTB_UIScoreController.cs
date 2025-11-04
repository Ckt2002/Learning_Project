using TMPro;
using UnityEngine;

public class CTB_UIScoreController : MonoBehaviour, IUIController<int>
{
    [SerializeField] TMP_Text scoreText;

    private void Start()
    {
        scoreText.text = 0.ToString();
    }

    public void UpdateUI(int value)
    {
        scoreText.text = value.ToString();
    }
}
