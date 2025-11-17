using System.Collections.Generic;
using UnityEngine;

public class ER3D_PlanesController : MonoBehaviour
{
    // new spawn pos = last pos + (last length size + new length size)/2

    [SerializeField] List<GameObject> planes;
    [SerializeField] float distanceToReset = 6;
    [SerializeField] float planeOffsetMultiply = 10;
    [SerializeField] float planesMoveSpeed;

    Quaternion targetRotation;
    Transform player;

    private void Start()
    {
        player = FindFirstObjectByType<ER3D_PlayerController>().transform;
    }

    private void Update()
    {
        int index = 0;

        while (index < planes.Count)
        {
            Transform plane = planes[index].transform;

            if (player.position.z > plane.transform.position.z &&
                player.position.z - plane.transform.position.z >= Mathf.Abs(distanceToReset))
            {
                planes.Remove(plane.gameObject);

                Transform lastPlane = planes[planes.Count - 1].transform;
                float distance = (plane.localScale.z / 2 + lastPlane.localScale.z / 2) * planeOffsetMultiply;
                Vector3 nextPos = new Vector3(lastPlane.position.x, lastPlane.position.y, lastPlane.position.z + distance);
                plane.position = nextPos;
                planes.Add(plane.gameObject);
            }
            else
                ++index;

            plane.transform.position += Vector3.back * planesMoveSpeed * Time.deltaTime;
        }


    }
}
