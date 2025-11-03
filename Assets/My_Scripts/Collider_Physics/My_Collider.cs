using UnityEngine;

public class My_Collider : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Collied");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered");
    }
}