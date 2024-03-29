using TMPro;
using UnityEngine;

/// <summary>
/// display the shell count of the player
/// </summary>
public class DisplayShellCount : MonoBehaviour
{
    /// <summary>
    /// player count shell text
    /// </summary>
    [SerializeField] private TextMeshProUGUI _shellCountText;

    /// <summary>
    /// change the text _shellCountText
    /// </summary>
    /// <param name="text">text content</param>
    public void EditText(string text)
    {
        _shellCountText.text = text;
    }
}
