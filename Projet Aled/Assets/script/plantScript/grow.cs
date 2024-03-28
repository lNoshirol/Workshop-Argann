using UnityEngine;

public class Grow : MonoBehaviour
{
    [SerializeField] private float _growSpeed;
    [SerializeField] private float _maxHighGrow;

    void Update()
    {
        transform.position += new Vector3(0, _growSpeed, 0) * Time.deltaTime;
        if (transform.position.y >= _maxHighGrow)
        {
            transform.position = new Vector3(transform.position.x, _maxHighGrow, transform.position.z);
            Destroy(GetComponent<Grow>());
        }
    }
}
