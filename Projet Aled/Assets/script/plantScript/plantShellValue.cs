using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plantShellValue : MonoBehaviour
{
    public int value { get; private set; }

    private void Start()
    {
        value = Random.Range(50, 150);
    }
}
