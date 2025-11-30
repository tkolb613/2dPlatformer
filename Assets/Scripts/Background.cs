using UnityEngine;

public class Background : MonoBehaviour
{
    public Transform player;
    public float parallaxFactor = 0.5f;   // smaller = farther away

    private Vector3 lastPlayerPos;

    void Start()
    {
        lastPlayerPos = player.position;
    }

    void Update()
    {
        float deltaX = player.position.x - lastPlayerPos.x;
        // Move background opposite to player's delta
        transform.Translate(Vector2.left * deltaX * parallaxFactor);
        lastPlayerPos = player.position;
    }
}