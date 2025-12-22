using UnityEngine;

public abstract class CS_AFEnemyCreator : MonoBehaviour
{
    [SerializeField] protected GameObject enemyPrefab;
    [SerializeField] protected Transform enemyPrarent;
    public abstract CS_IFEnemy CreateEnemy();
}