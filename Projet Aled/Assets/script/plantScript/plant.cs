using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plant : MonoBehaviour
{
    [SerializeField] private GameObject thePlant;
    [SerializeField] private bool isPlanted;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "shellGroup" && !isPlanted)
        {
            isPlanted = true;
        }
        else if (other.gameObject.tag == "tankShell" && !isPlanted)
        {
            GameObject newPlant = Instantiate(thePlant);
            newPlant.transform.position = new Vector3(transform.position.x, newPlant.transform.position.y, transform.position.z);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "shellGroup")
        {
            isPlanted = false;
        }
    }
}
