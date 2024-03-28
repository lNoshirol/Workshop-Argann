using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LeopardFire : MonoBehaviour
{
    [SerializeField] GameObject shellSpawnLocation;
    [SerializeField] GameObject _shell;
    private ShellCount _shellCount;

    private void Start()
    {
        _shellCount = GetComponent<ShellCount>();
        _shellCount.shellCountText.text = _shellCount.shellCount.ToString();
    }

    public void OnFire(InputAction.CallbackContext callbackContext)
    {
        if (callbackContext.started)
        {
            if (_shellCount.shellCount > 0)
            {
                GameObject _newShell = Instantiate(_shell);
                _newShell.transform.position = shellSpawnLocation.transform.position;
                _newShell.transform.rotation = shellSpawnLocation.transform.rotation;
                _shellCount.shellCount--;
                _shellCount.shellCountText.text = _shellCount.shellCount.ToString();
            }

            
        }
    }
}
