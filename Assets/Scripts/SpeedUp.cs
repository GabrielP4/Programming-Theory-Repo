using System.Collections;
using UnityEngine;

public class SpeedUp : PowerUp
{
    public override IEnumerator Pickup(Collider player) //POLYMORPHISM 
    {
        Instantiate(pickupEffect, transform.position, transform.rotation);
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;

        PaddleMovement playerStats = player.GetComponent<PaddleMovement>();

        if (playerStats.Speed < 4)
        {
            playerStats.Speed *= multiplier;
        }

        yield return new WaitForSeconds(lastFor);

        if (playerStats.Speed == 4)
        {
            playerStats.Speed /= multiplier;
        }
        Destroy(gameObject);
    }
}
