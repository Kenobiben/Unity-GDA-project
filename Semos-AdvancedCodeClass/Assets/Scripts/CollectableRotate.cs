using UnityEngine;

public class CollectableRotate : MonoBehaviour
{
    [SerializeField]
    private float rotateSpeed;
    void Update()
    {
        Vector3 rotation = transform.eulerAngles;
        rotation.y += rotateSpeed;
        transform.eulerAngles = rotation;
    }
}
