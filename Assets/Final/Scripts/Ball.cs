using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(transform.up * speed);

    }

    void OneBecomeInvisible()
    {
        Destroy(gameObject);
    }
<<<<<<< Updated upstream
=======

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Enemy enemyHp = collision.gameObject.GetComponent<Enemy>();

            if (enemyHp != null)
            {
               
                Debug.Log("Enemy got damaged.");
            }
            Destroy(gameObject);

        }
    }
>>>>>>> Stashed changes
}
