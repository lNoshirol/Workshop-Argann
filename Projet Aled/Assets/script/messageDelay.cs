using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class messageDelay : MonoBehaviour
{
    private void OnEnable()
    {
        StartCoroutine(SetActiveFalseDelay());
    }

    IEnumerator SetActiveFalseDelay()
    {
        yield return new WaitForSeconds(2);
        gameObject.SetActive(false);
    }
}
