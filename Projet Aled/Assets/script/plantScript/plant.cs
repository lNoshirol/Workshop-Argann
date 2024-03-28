using UnityEngine;

public class Plant : MonoBehaviour
{
    [SerializeField] private GameObject _thePlant;
    [SerializeField] private bool _isPlanted;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("shellGroup") && !_isPlanted)
        {
            _isPlanted = true;
        }
        else if (other.CompareTag("tankShell") && !_isPlanted)
        {
            GameObject newPlant = Instantiate(_thePlant);
            newPlant.transform.position = new Vector3(transform.position.x, newPlant.transform.position.y, transform.position.z);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("shellGroup"))
        {
            _isPlanted = false;
        }
    }
}
