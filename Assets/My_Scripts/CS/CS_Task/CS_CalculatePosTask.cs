using System.Threading.Tasks;
using UnityEngine;

public static class CS_CalculatePosTask
{
    private static readonly System.Random random = new();

    public static async Task<Vector3> CalculatePositionAsync(Vector3 currentPosition)
    {
        try
        {
            float offsetX = (float)(random.NextDouble() * 2f - 1f);
            float offsetY = (float)(random.NextDouble() * 2f - 1f);
            float offsetZ = (float)(random.NextDouble() * 2f - 1f);

            Vector3 newPosition = new Vector3(
                currentPosition.x + offsetX,
                currentPosition.y + offsetY,
                currentPosition.z + offsetZ
            );

            return newPosition;
        }
        catch (System.Exception e)
        {
            Debug.LogError($"An unexpected error occurred: {e.Message}");
            return currentPosition;
        }
    }
}