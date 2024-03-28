using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class grow : MonoBehaviour
{
    [SerializeField] private float growSpeed;
    [SerializeField] private float maxHighGrow;

    void Update()
    {
        transform.position += new Vector3(0, growSpeed, 0) * Time.deltaTime;
        if (transform.position.y >= maxHighGrow)
        {
            transform.position = new Vector3(transform.position.x, maxHighGrow, transform.position.z);
            Destroy(GetComponent<grow>());
        }
    }
}
