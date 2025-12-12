using UnityEngine;
using Unity.VisualScripting;

public class FallingPlatform : MonoBehaviour
{
    public float timeBeforeFall;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            transform.AddComponent<Rigidbody2D>();
        }
    }
}
