using UnityEngine;

public class PlayerWalkStrategy : CS_IMoveStrategy
{
    public void Move(Transform t, Vector3 direction, float speed)
    {
        t.Translate(direction * speed * Time.deltaTime, Space.World);

        if (direction != Vector3.zero)
        {
            t.forward = Vector3.Slerp(t.forward, direction, Time.deltaTime * 10f);
        }
    }
}

public class PlayerFlyStrategy : CS_IMoveStrategy
{
    public void Move(Transform t, Vector3 direction, float speed)
    {
        Vector3 lift = Vector3.up * 0.5f;
        Vector3 finalVelocity = (direction + lift).normalized;

        t.Translate(finalVelocity * speed * Time.deltaTime, Space.World);
    }
}