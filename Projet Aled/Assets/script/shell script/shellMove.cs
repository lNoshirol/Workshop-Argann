using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shellMove : MonoBehaviour
{
    [SerializeField] private float shellSpeed;

    private void FixedUpdate()
    {
        transform.Translate(Vector3.up * shellSpeed * Time.deltaTime);
        
    }
}