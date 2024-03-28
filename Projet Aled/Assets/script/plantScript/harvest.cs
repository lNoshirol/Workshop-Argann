using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class harvest : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "tonk" && transform.position.y == 0.738f)
        {
            other.GetComponent<buyShell>().EditMoneyAmount(GetComponent<plantShellValue>().value);
            Destroy(gameObject);
        }
    }
}
