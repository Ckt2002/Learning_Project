using UnityEngine;

public interface CS_IMoveStrategy
{
    void Move(Transform transform, Vector3 direction, float speed);
}