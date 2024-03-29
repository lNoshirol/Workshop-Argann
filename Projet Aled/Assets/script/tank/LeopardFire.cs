using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// fire a shell
/// </summary>
public class LeopardFire : MonoBehaviour
{
    /// <summary>
    /// position where the shell spawn
    /// </summary>
    [SerializeField] GameObject _shellSpawnLocation;
    /// <summary>
    /// shell object
    /// </summary>
    [SerializeField] GameObject _shell;
    /// <summary>
    /// reference to shell manager
    /// </summary>
    private ShellCount _shellCount;

    private void Start()
    {
        _shellCount = GetComponent<ShellCount>();
    }

    public void OnFire(InputAction.CallbackContext callbackContext)
    {
        //fire a shell if player press the button and if player have enough shell
        if (!callbackContext.started || _shellCount.TonkShellCount <= 0) return;

        //create shell in the scene
        GameObject _newShell = Instantiate(_shell);
        _newShell.transform.position = _shellSpawnLocation.transform.position;
        _newShell.transform.rotation = _shellSpawnLocation.transform.rotation;

        //update shell count
        _shellCount.EditShellCount(-1);
    }
}
