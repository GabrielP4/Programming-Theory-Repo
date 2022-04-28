using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    private float maxMagnitude = 5.0f;
    private Rigidbody rigidBody;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    private void OnCollisionExit(Collision collision)
    {
        var velocity = rigidBody.velocity;
        velocity += velocity.normalized * 5f;

        if (Vector3.Dot(velocity.normalized, Vector3.up) < 0.1f)
        {
            velocity += velocity.y > 0 ? Vector3.up * 0.5f : Vector3.down * 0.5f;
        }
        if (Vector3.Dot(velocity.normalized, Vector3.right) < 0.1f)
        {
            velocity += velocity.y > 0 ? Vector3.right * 0.5f : Vector3.left * 0.5f;
        }
        if (velocity.magnitude > maxMagnitude)
        {
            velocity = velocity.normalized * maxMagnitude;
        }
        rigidBody.velocity = velocity;
    }
}
