using UnityEngine;

/// <summary>
/// move a shell
/// </summary>
public class ShellMove : MonoBehaviour
{
    /// <summary>
    /// movement speed of the shell
    /// </summary>
    [SerializeField] private float _shellSpeed;

    private void FixedUpdate()
    {
        //move the shell
        transform.Translate(Vector3.up * _shellSpeed * Time.deltaTime);
    }
}