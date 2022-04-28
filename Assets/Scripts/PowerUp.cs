using System.Collections;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    protected float lastFor = 5;
    protected float fallSpeed;
    protected Vector3 scaleChange = new Vector3(2f, 0, 0);
    protected float multiplier = 2;
    protected int dropSpeed = -2;

    public GameObject pickupEffect;

    private void Update()
    {
        transform.Translate(0, dropSpeed * Time.deltaTime, 0);
        if (transform.position.y < -5)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(Pickup(other));
        }
    }

    public virtual IEnumerator Pickup(Collider player)
    {
        Debug.Log("Power up picked up!");
        yield return new WaitForSeconds(lastFor);
    }
}