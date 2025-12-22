using UnityEngine;

public class CS_FGoblin : MonoBehaviour, CS_IFEnemy
{
    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            if (Input.GetKeyDown(KeyCode.G))
            {
                Debug.Log("Goblin returned to pool.");
                CS_FEnemyPooling.ReturnEnemy(CS_EFEnemyEnum.Goblin, this);
            }
        }
    }

    public void Attack()
    {
    }

    public void Move()
    {
    }
}