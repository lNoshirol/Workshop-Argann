using UnityEngine;
using UnityEngine.InputSystem;

public class LeopardFire : MonoBehaviour
{
    [SerializeField] GameObject _shellSpawnLocation;
    [SerializeField] GameObject _shell;
    private ShellCount _shellCount;

    private void Start()
    {
        _shellCount = GetComponent<ShellCount>();
        _shellCount.ShellCountText.text = _shellCount.TonkShellCount.ToString();
    }

    public void OnFire(InputAction.CallbackContext callbackContext)
    {
        if (callbackContext.started)
        {
            if (_shellCount.TonkShellCount > 0)
            {
                GameObject _newShell = Instantiate(_shell);
                _newShell.transform.position = _shellSpawnLocation.transform.position;
                _newShell.transform.rotation = _shellSpawnLocation.transform.rotation;
                _shellCount.TonkShellCount--;
                _shellCount.ShellCountText.text = _shellCount.TonkShellCount.ToString();
            }
        }
    }
}
