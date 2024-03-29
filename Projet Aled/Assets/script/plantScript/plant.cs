using UnityEngine;

public class Plant : MonoBehaviour
{
    /// <summary>
    /// Plant that will grow in the field
    /// </summary>
    [SerializeField] private GameObject _thePlant;
    /// <summary>
    /// used to know if the field is planted
    /// </summary>
    [SerializeField] private bool _isPlanted;

    private void OnTriggerEnter(Collider other)
    {
        //check if the gameObject in the field is a seed and if the field is not planted
        if (other.CompareTag("tankShell") && !_isPlanted)
        {
            //plant the field
            GameObject newPlant = Instantiate(_thePlant);
            newPlant.transform.position = new Vector3(transform.position.x, newPlant.transform.position.y, transform.position.z);
            _isPlanted = true;
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        //set _isPlanted to false if the plant leaves the field
        if (other.CompareTag("shellGroup"))
        {
            _isPlanted = false;
        }
    }
}