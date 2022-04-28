using UnityEngine;

public class Brick : MonoBehaviour
{
    public GameObject[] drop;
    private void OnCollisionEnter(Collision collision)
    {
        int randomDrop = Random.Range(0, 2);
        int randomSpanw = Random.Range(0, 11);
        if (randomSpanw % 2 == 0)
        {
            Instantiate(drop[randomDrop], transform.position, transform.rotation);
        }
        Destroy(gameObject, 0.1f);
    }
}
