using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LeopardFire : MonoBehaviour
{
    [SerializeField] GameObject shellSpawnLocation;
    [SerializeField] GameObject _shell;



    public void OnFire(InputAction.CallbackContext callbackContext)
    {
        if (callbackContext.started)
        {
            GameObject _newShell = Instantiate(_shell);
            _newShell.transform.position = shellSpawnLocation.transform.position;
            _newShell.transform.rotation = shellSpawnLocation.transform.rotation;
        }
    }
}
