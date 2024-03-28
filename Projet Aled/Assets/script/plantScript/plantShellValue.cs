using UnityEngine;

public class PlantShellValue : MonoBehaviour
{
    public int Value { get; private set; }

    private void Start()
    {
        Value = Random.Range(50, 150);
    }
}
