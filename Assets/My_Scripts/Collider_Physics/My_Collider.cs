using UnityEngine;

public class My_Collider : MonoBehaviour
{
    [SerializeField] private GameObject a;

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Collied");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered");
    }
}