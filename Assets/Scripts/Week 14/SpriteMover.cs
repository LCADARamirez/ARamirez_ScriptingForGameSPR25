
using UnityEngine;

public class SpriteMover : MonoBehaviour
{
    public float speed = 5f;
    private Vector2 direction;

    void Start()
    {
        // Set a random initial direction
        direction = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
    }

    void Update()
    {
        // Move the sprite based on the direction and speed
        transform.Translate(direction * speed * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check for collision with side walls
        if (collision.gameObject.CompareTag("SideWall"))
        {
            direction.x = -direction.x;
        }
        // Check for collision with top or bottom walls
        else if (collision.gameObject.CompareTag("VerticalWall"))
        {
            direction.y = -direction.y;
        }
    }
}
