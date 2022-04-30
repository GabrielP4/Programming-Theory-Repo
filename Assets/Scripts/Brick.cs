using UnityEngine;

public class Brick : MonoBehaviour
{
    [SerializeField]
    private GameObject[] drop;
    private void OnCollisionEnter(Collision collision)
    {
        GenerateDrop();
        BrickPoint();
        Destroy(gameObject, 0.1f);
    }

    private void BrickPoint()
    {
        GameManager.score += 1;
    }

    private void GenerateDrop()
    {
        int randomDrop = Random.Range(0, 2);
        int randomSpanw = Random.Range(0, 11);
        if (randomSpanw % 2 == 0)
        {
            Instantiate(drop[randomDrop], transform.position, transform.rotation);
        }
    }
}
