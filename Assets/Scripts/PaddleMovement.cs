using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    private float border = 4.25f; //3.25
    private float speed = 2;
    public float Border { get => border; set => border = value; }
    public float Speed { get => speed; set => speed = value; }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        float input = Input.GetAxis("Horizontal");

        Vector3 pos = transform.position;
        pos.x += input * Speed * Time.deltaTime;

        if (pos.x > Border)
        {
            pos.x = Border;
        }
        else if (pos.x < -Border)
        {
            pos.x = -Border;
        }
        transform.position = pos;
    }
}
