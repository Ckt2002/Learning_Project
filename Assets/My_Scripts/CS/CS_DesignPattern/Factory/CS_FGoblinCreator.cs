using UnityEngine;

public class CS_FGoblinCreator : CS_AFEnemyCreator
{
    public override CS_IFEnemy CreateEnemy()
    {
        GameObject orcObj = Instantiate(enemyPrefab, enemyPrarent);
        return orcObj.GetComponent<CS_IFEnemy>();
    }
}