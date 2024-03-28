using UnityEngine;

public class ShotDirectionIndicator : MonoBehaviour
{
    private LineRenderer _line;
    [SerializeField] private GameObject _pointForLaser;
    private void Start()
    {
        _line = GetComponent<LineRenderer>();
    }
    void Update()
    {   
        _line.SetPosition(0, transform.position);
        _line.SetPosition(1, _pointForLaser.transform.position);
    }
}
