using System.Threading.Tasks;
using UnityEngine;

public static class CS_MultiTask
{
    public static async Task RunMultipleTasksAsync()
    {
        var taskA = TaskA();
        var taskB = TaskB();
        var taskC = TaskC();

        await Task.WhenAll(taskA, taskB, taskC);

        Debug.Log("All tasks completed.");
    }

    private static async Task TaskA()
    {
        await Task.Delay(3000);
        Debug.Log("Task A1 completed.");
        await Task.Delay(3000);
        Debug.Log("Task A2 completed.");
    }

    private static async Task TaskB()
    {
        await Task.Delay(5000);
        Debug.Log("Task B1 completed.");
        await Task.Delay(5000);
        Debug.Log("Task B2 completed.");
    }

    private static async Task TaskC()
    {
        await Task.Delay(8000);
        Debug.Log("Task C completed.");
    }
}