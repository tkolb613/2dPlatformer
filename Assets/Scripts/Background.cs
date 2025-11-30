using UnityEngine;

public class Background : MonoBehaviour
{
    public float scrollSpeed = 2f;

    private float spriteWidth;

    void Start()
    {
        spriteWidth = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void Update()
    {
        // Move left every frame
        transform.Translate(Vector2.left * scrollSpeed * Time.deltaTime);

        // If off screen, move to the right of the other sprite
        if (transform.position.x <= -spriteWidth)
        {
            transform.position += Vector3.right * spriteWidth * 2f;
        }
    }
}
