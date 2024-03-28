using UnityEngine;
using UnityEngine.InputSystem;

public class LeopardMove : MonoBehaviour
{
    [SerializeField] private int movementSpeed;
    [SerializeField] private float canonLevageSpeed;
    [SerializeField] private float hullRotateSpeed;
    [SerializeField] private float rotateSpeed;

    private Vector3 mouvement;
    private Vector2 InputAxis;

    public GameObject turret;
    public GameObject canon;

    private Transform canonTransform;

    private void Start()
    {
        canonTransform = canon.transform;
    }

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

        if (canonTransform.rotation.x >= -9 && canonTransform.rotation.x <= 20)
        {
            canon.transform.Rotate(new Vector3(InputAxis.y, 0, 0) * canonLevageSpeed * Time.deltaTime);
            //Debug.Log(canonTransform.rotation.eulerAngles.x);
        }
        else if (canonTransform.rotation.x <= -9)
        {
            //ARGANN REPARE
        }
        else if (canonTransform.rotation.x >= 20)
        {
            //ARGANN REPARE
        }
    }
}
