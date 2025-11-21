using UnityEngine;

public class BallModified : MonoBehaviour
{
    private float speed = 150;
    private Rigidbody2D rb;

    void Start()
    {
        if (rb == null)
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    public void OnPlayerDeath()
    {
        rb.AddForce(transform.up * speed);
    }
    void OneBecomeInvisible()
    {
        Destroy(gameObject);
    }
}
