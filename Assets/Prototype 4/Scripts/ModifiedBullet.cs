using UnityEngine;

public class ModifiedBullet : MonoBehaviour
{
    public float speed = 150;
    private Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    public void OnPlayerDeath()
    {
        rb.AddForce(transform.up * speed);
    }

    void OneBecomeInvisible()
    {
        Destroy (gameObject);
    }
}