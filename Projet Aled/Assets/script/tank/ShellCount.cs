using UnityEngine;

/// <summary>
/// player shell manager
/// </summary>
public class ShellCount : MonoBehaviour
{
    /// <summary>
    /// player shell count
    /// </summary>
    [field : SerializeField] public int TonkShellCount { get; private set; }

    private DisplayShellCount _displayShell;

    private void Start()
    {
        _displayShell = GetComponent<DisplayShellCount>();
        EditShellCount(0);
    }

    /// <summary>
    /// add a certain amount of shell
    /// </summary>
    /// <param name="value"></param>
    public void EditShellCount(int value)
    {
        TonkShellCount += value;
        _displayShell.EditText(TonkShellCount.ToString());
    }
}