using UnityEngine;
/// <summary>
/// Destroy the object after the choosen time
/// </summary>
public class DestroyCooldown : MonoBehaviour
{
    /// <summary>
    /// time before destroy GameObject
    /// </summary>
    [SerializeField]
    private float _cooldown;

    private void Start()
    {
        //destroy the gameObject after the time choose
        Destroy(gameObject, _cooldown);
    }
}
