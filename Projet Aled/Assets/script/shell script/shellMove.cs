using UnityEngine;

public class ShellMove : MonoBehaviour
{
    [SerializeField] private float _shellSpeed;

    private void FixedUpdate()
    {
        transform.Translate(Vector3.up * _shellSpeed * Time.deltaTime);
    }
}