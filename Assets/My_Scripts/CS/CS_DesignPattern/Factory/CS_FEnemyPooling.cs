using System.Collections.Generic;
using UnityEngine;

public class CS_FEnemyPooling : MonoBehaviour
{
    [System.Serializable]
    public struct CreatorMapping
    {
        public CS_EFEnemyEnum type;
        public CS_AFEnemyCreator creator;
    }

    public static CS_FEnemyPooling Instance { get; private set; }

    [SerializeField] private CreatorMapping[] creatorMappings;

    private static Dictionary<CS_EFEnemyEnum, CS_AFEnemyCreator> enemyCreators = new();
    private static Dictionary<CS_EFEnemyEnum, Queue<CS_IFEnemy>> availablePools = new();

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            InitializePools();
        }
        else
            Destroy(gameObject);
    }

    private void InitializePools()
    {
        foreach (var mapping in creatorMappings)
        {
            if (availablePools.ContainsKey(mapping.type))
                continue;

            enemyCreators[mapping.type] = mapping.creator;
            Queue<CS_IFEnemy> queue = new Queue<CS_IFEnemy>();
            for (int i = 0; i < 5; i++)
            {
                var enemy = mapping.creator.CreateEnemy();
                if (enemy is MonoBehaviour mb)
                {
                    mb.gameObject.SetActive(false);
                    queue.Enqueue(enemy);
                }
            }

            availablePools[mapping.type] = queue;
        }
    }

    public static CS_IFEnemy GetEnemy(CS_EFEnemyEnum type)
    {
        if (!availablePools.TryGetValue(type, out var queue))
        {
            Debug.LogError($"Enemy type {type} not configured");
            return null;
        }

        CS_IFEnemy enemy;

        if (queue.Count > 0)
            enemy = queue.Dequeue();
        else
            enemy = enemyCreators[type].CreateEnemy();

        if (enemy is MonoBehaviour mb)
            mb.gameObject.SetActive(true);

        return enemy;
    }

    public static void ReturnEnemy(CS_EFEnemyEnum type, CS_IFEnemy enemy)
    {
        if (!availablePools.TryGetValue(type, out var queue)) return;

        if (enemy is MonoBehaviour mb)
            mb.gameObject.SetActive(false);

        queue.Enqueue(enemy);
    }
}