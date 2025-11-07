using UnityEngine;

public class ER2D_GroundPooling : MonoBehaviour
{
    [SerializeField] GameObject groundPrefab;
    [SerializeField] Transform groundsParent;

    public GameObject SpawnNewGround()
    {
        return Instantiate(groundPrefab, groundsParent);
    }
}
