using UnityEngine;
using UnityEngine.InputSystem;

public class LeopardMove : MonoBehaviour
{
    public int movementSpeed;
    public float canonLevageSpeed;
    public float hullRotateSpeed;
    public float rotateSpeed;

    public Vector3 mouvement;
    public Vector2 InputAxis;

    public GameObject turret;
    public GameObject canon;

    public void OnMoveTonk(InputAction.CallbackContext callbackContext)
    {
        Vector2 orientation = callbackContext.ReadValue<Vector2>();
        mouvement = new Vector3(orientation.x, 0, orientation.y);
    }

    public void OnRotateTourelle(InputAction.CallbackContext callbackContext)
    {
        InputAxis = callbackContext.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        if (mouvement.z >= 0)
        {
            transform.Translate(new Vector3(0, 0, -mouvement.z) * movementSpeed * Time.deltaTime);
        }
        else if (mouvement.z < 0)
        {
            transform.Translate(new Vector3(0, 0, -mouvement.z) * movementSpeed * Time.deltaTime);
        }

        transform.Rotate(new Vector3(0, mouvement.x, 0) * hullRotateSpeed * Time.deltaTime);
        if (mouvement != Vector3.zero && InputAxis == Vector2.zero)
        {
            turret.transform.Rotate(new Vector3(0, 0, -mouvement.x) * hullRotateSpeed * Time.deltaTime);
        }

        turret.transform.Rotate(new Vector3(0, 0, InputAxis.x) * rotateSpeed * Time.deltaTime);
        canon.transform.Rotate(new Vector3(InputAxis.y, 0, 0) * canonLevageSpeed * Time.deltaTime);
    }
}
