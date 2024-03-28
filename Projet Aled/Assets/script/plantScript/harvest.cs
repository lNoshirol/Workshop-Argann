using UnityEngine;

public class Harvest : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("tonk") && transform.position.y == 0.738f)
        {
            other.GetComponent<BuyShell>().EditMoneyAmount(GetComponent<PlantShellValue>().Value);
            gameObject.transform.position -= Vector3.down * 10;
            Destroy(gameObject);
        }
    }
}
