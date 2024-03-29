using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// make the player move
/// </summary>
public class LeopardMove : MonoBehaviour
{
    /// <summary>
    /// movement speed
    /// </summary>
    [SerializeField] private int _movementSpeed;

    /// <summary>
    /// vertical guidance speed
    /// </summary>
    [SerializeField] private float _canonLevageSpeed;

    /// <summary>
    /// hull rotation speed
    /// </summary>
    [SerializeField] private float _hullRotateSpeed;

    /// <summary>
    /// turret rotation speed
    /// </summary>
    [SerializeField] private float _turretRotateSpeed;

    /// <summary>
    /// turret object
    /// </summary>
    [SerializeField] private GameObject _turret;

    /// <summary>
    /// canon object
    /// </summary>
    [SerializeField] private GameObject _canon;

    /// <summary>
    /// left stick vector
    /// </summary>
    private Vector3 _mouvement;

    /// <summary>
    /// right stick vector
    /// </summary>
    private Vector2 _inputAxis;

    /// <summary>
    /// set movement vector at left stick vector
    /// </summary>
    /// <param name="callbackContext"></param>
    public void OnMoveTonk(InputAction.CallbackContext callbackContext)
    {
        Vector2 orientation = callbackContext.ReadValue<Vector2>();
        _mouvement = new Vector3(orientation.x, 0, orientation.y);
    }

    /// <summary>
    ///  set inputAxis vector at left stick vector
    /// </summary>
    /// <param name="callbackContext"></param>
    public void OnRotateTourelle(InputAction.CallbackContext callbackContext)
    {
        _inputAxis = callbackContext.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        //move the player on his z axis
        transform.Translate(_movementSpeed * Time.deltaTime * new Vector3(0, 0, -_mouvement.z));

        //rotate the hull 
        transform.Rotate(_hullRotateSpeed * Time.deltaTime * new Vector3(0, _mouvement.x, 0));

        //make the turrete don't rotate with the hull
        if (_mouvement != Vector3.zero && _inputAxis == Vector2.zero)
        {
            _turret.transform.Rotate(_hullRotateSpeed * Time.deltaTime * new Vector3(0, 0, -_mouvement.x));
        }
        
        //rotate the turret
        _turret.transform.Rotate(_turretRotateSpeed * Time.deltaTime * new Vector3(0, 0, _inputAxis.x));
        
        //increase or decrease canon angle
        _canon.transform.Rotate(_canonLevageSpeed * Time.deltaTime * new Vector3(_inputAxis.y, 0, 0));
    }
}