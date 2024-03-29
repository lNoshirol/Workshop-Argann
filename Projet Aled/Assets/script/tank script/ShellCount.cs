using UnityEngine;
using TMPro;

/// <summary>
/// player shell manager
/// </summary>
public class ShellCount : MonoBehaviour
{
    /// <summary>
    /// player count shell text
    /// </summary>
    [field : SerializeField] public TextMeshProUGUI ShellCountText {  get; set; }

    /// <summary>
    /// player shell count
    /// </summary>
    [field: SerializeField] public int TonkShellCount {  get; set; }
}
