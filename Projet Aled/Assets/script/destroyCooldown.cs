using UnityEngine;

public class DestroyCooldown : MonoBehaviour
{
    [SerializeField]
    private float _cooldown;

    private void Start()
    {
        Destroy(gameObject, _cooldown);
    }
}
