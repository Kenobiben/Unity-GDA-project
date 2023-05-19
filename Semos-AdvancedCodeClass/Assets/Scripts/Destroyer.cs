using UnityEngine;

public class Destroyer : MonoBehaviour
{

    private void OnCollisionEnter(Collision other)
    {
        Destroy(other.transform.parent.gameObject);
    }
}
