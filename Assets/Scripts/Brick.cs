using UnityEngine;

public class Brick : MonoBehaviour
{
    public GameObject drop;
    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(drop, transform.position, transform.rotation);
        Destroy(gameObject, 0.1f);
    }
}
