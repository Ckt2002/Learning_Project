using System.Threading;
using UnityEngine;

public class CS_Task : MonoBehaviour
{
    CancellationTokenSource cts;
    public Transform cubeTransform;

    private void Awake()
    {
        cts = new CancellationTokenSource();
    }

    async void Start()
    {
        var taskToken = cts.Token;

        await CS_MultiTask.RunMultipleTasksAsync();
        await CS_TaskCancellation.CheckTaskCancellation(taskToken);
    }

    async void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            cts.Cancel();
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            Vector3 newPos = await CS_CalculatePosTask.CalculatePositionAsync(cubeTransform.position);
            cubeTransform.position = newPos;
            Debug.Log($"Cube new position: {cubeTransform.position}");
        }
    }

    void OnDestroy()
    {
        cts?.Cancel();
        cts?.Dispose();
        cts = null;
    }
}
