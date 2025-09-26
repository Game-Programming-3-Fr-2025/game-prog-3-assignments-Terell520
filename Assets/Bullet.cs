using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = transform.up * speed;
    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
       // Enemy enemy = collision.GetComponent<Enemy>();
       // if (enemy != null)
        //{
           // enemy.TakeDamage(2);
        //}
        //Destroy(gameObject);
    //}
}
