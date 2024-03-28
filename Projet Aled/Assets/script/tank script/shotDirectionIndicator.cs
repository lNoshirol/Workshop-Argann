using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotDirectionIndicator : MonoBehaviour
{
    private LineRenderer line;
    [SerializeField] private GameObject pointForLaser;
    private void Start()
    {
        line = GetComponent<LineRenderer>();
    }
    void Update()
    {   
        line.SetPosition(0, transform.position);
        line.SetPosition(1, pointForLaser.transform.position);
    }
}
