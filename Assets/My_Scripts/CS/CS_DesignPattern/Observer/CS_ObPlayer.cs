using UnityEngine;

public class CS_ObPlayer : MonoBehaviour
{
    private int gold;
    private int health = 100;

    public float timeToGetGold = 2f;
    private float timer = 0f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G) && (timer >= timeToGetGold))
        {
            gold += 10;
            timer = 0f;
            OnGoldChange();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (health > 0)
            {
                health -= Random.Range(5, 20);
                health = Mathf.Clamp(health, 0, 100);
                OnTakeDamage();
            }
            else
                Debug.Log("Player is dead.");
        }
        timer += Time.deltaTime;
    }

    private void OnGoldChange()
    {
        CS_ObGlobalEvent.PlayerChangeEvent.NotifyObservers(CS_ObEChangeType.Gold, gold);
    }

    private void OnTakeDamage()
    {
        CS_ObGlobalEvent.PlayerChangeEvent.NotifyObservers(CS_ObEChangeType.Hp, health);
    }
}
