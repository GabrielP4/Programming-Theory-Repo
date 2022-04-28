using System.Collections;
using UnityEngine;

public class ScaleUp : PowerUp
{
    public override IEnumerator Pickup(Collider player)
    {

        Instantiate(pickupEffect, transform.position, transform.rotation);
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;

        PaddleMovement playerStats = player.GetComponent<PaddleMovement>();

        if (player.transform.localScale.x < 4)
        {
            player.transform.localScale += scaleChange;
            playerStats.Border = 3.25f;
        }

        yield return new WaitForSeconds(lastFor);

        if (player.transform.localScale.x == 4)
        {
            player.transform.localScale -= scaleChange;
            playerStats.Border = 4.25f;
        }


        Destroy(gameObject);
    }
}
