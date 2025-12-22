using UnityEngine;

public class CS_FOgre : MonoBehaviour, CS_IFEnemy
{
    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            if (Input.GetKeyDown(KeyCode.O))
            {
                Debug.Log("Ogre returned to pool.");
                CS_FEnemyPooling.ReturnEnemy(CS_EFEnemyEnum.Ogre, this);
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