using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public static class CS_TaskCancellation
{
    public static async Task CheckTaskCancellation(CancellationToken token)
    {
        try
        {
            for (int i = 0; i < 10; i++)
            {
                token.ThrowIfCancellationRequested();

                Debug.Log($"Đang xử lý bước {i}...");
                await Task.Delay(10000, token);
            }
        }
        catch (System.OperationCanceledException)
        {
            Debug.Log("Task was canceled.");
        }
    }
}