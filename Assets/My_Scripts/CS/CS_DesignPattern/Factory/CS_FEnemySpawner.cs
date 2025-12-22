using UnityEngine;

public class CS_FEnemySpawner : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            Debug.Log("Left Shift Pressed - No Action Assigned");
            return;
        }
        if (Input.GetKeyDown((KeyCode)CS_EFSpawnButton.SpawnGoblin))
        {
            CS_FEnemyPooling.GetEnemy(CS_EFEnemyEnum.Goblin);
        }

        if (Input.GetKeyDown((KeyCode)CS_EFSpawnButton.SpawnOgre))
        {
            CS_FEnemyPooling.GetEnemy(CS_EFEnemyEnum.Ogre);
        }
    }
}