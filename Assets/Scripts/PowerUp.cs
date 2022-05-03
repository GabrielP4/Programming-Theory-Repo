using System.Collections;
using UnityEngine;

public class PowerUp : MonoBehaviour //INHERITANCE Parent Class fo ScaleUp and SpeedUp
{
    protected float lastFor = 5;
    protected float fallSpeed;
    protected Vector3 scaleChange = new Vector3(2f, 0, 0);
    protected float multiplier = 2;
    protected int dropSpeed = -2;

    [SerializeField]
    protected GameObject pickupEffect;

    private void Update()
    {
        transform.Translate(0, dropSpeed * Time.deltaTime, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(Pickup(other));
        }
        else if (other.CompareTag("DeathZone"))
        {
            Destroy(gameObject);
        }
    }

    public virtual IEnumerator Pickup(Collider player) //POLYMORPHISM Base implemenatation of pickup method
    {
        Debug.Log("Power up picked up!");
        yield return new WaitForSeconds(lastFor);
    }
}
