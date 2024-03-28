using System.Collections;
using UnityEngine;

public class MessageDelay : MonoBehaviour
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
