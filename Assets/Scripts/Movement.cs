using UnityEngine;

public class Movement : MonoBehaviour
{
    Fox fox = new Fox();
    Jugi jugi = new Jugi();
    Seal seal = new Seal();
    Dove dove = new Dove();

    public void Start()
    {
        fox.Howl();
        jugi.Glomp();
        dove.Tweet();
        seal.Clap();
        dove.Tweet();

    }
    float moveSpeed = 5.0f;
    void Update()
    {
        float dt = Time.deltaTime;

        // Directional movement
        Vector3 direction = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            direction += Vector3.up;
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction += Vector3.down;
        }
        if (Input.GetKey(KeyCode.A))
        {
            direction += Vector3.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction += Vector3.right;
        }
        direction = direction.normalized;
        Vector3 movement = direction * moveSpeed * dt;
        transform.position += movement;
    }
}
