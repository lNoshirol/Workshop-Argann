using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyCooldown : MonoBehaviour
{
    [SerializeField] float cooldown;

    private void Start()
    {
        Destroy(gameObject, cooldown);
    }
}
