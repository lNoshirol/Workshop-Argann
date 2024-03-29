using UnityEngine;

/// <summary>
/// show the direction where the player will fire
/// </summary>
public class ShotDirectionIndicator : MonoBehaviour
{
    /// <summary>
    /// empty GameObject with the position
    /// </summary>
    [SerializeField] private GameObject _pointForLaser;
    
    /// <summary>
    /// LineRanderer component
    /// </summary>
    private LineRenderer _line;

    private void Start()
    {
        _line = GetComponent<LineRenderer>();
    }
    void Update()
    {   
        _line.SetPosition(0, transform.position - new Vector3(0, 0.185f, 0));
        _line.SetPosition(1, _pointForLaser.transform.position);
    }
}
