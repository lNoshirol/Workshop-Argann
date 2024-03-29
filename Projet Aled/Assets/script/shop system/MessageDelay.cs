using System.Collections;
using UnityEngine;

/// <summary>
/// show error message
/// </summary>
public class MessageDelay : MonoBehaviour
{
    private void OnEnable()
    {
        StartCoroutine(SetActiveFalseDelay());
    }
    /// <summary>
    /// Disables the object after 2 seconds
    /// </summary>
    /// <returns></returns>
    IEnumerator SetActiveFalseDelay()
    {
        yield return new WaitForSeconds(2);
        gameObject.SetActive(false);
    }
}