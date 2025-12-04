using UnityEngine;

public class Flag : MonoBehaviour
{
    public GameObject winUI;
    // Start is called once before the first execution of Update after the MonoBehaviour is created




    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Time.timeScale = 0;
            winUI.SetActive(true);
        }
    }


}
