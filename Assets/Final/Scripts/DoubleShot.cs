using UnityEngine;

public class DoubleShot : MonoBehaviour
{
    private float speed = 100;
    [SerializeField] Rigidbody2D rb;
    private int appliedDamage = 2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (rb == null)
        rb = GetComponent<Rigidbody2D>();
    }

    public void OnPlayerDeath()
    {
        rb.AddForce(transform.up * speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Enemy enemyHp = collision.gameObject.GetComponent<Enemy>();

            if (enemyHp != null)
            {
                enemyHp.TakeDamage(appliedDamage);
                Debug.Log("Enemy got damaged.");
            }
            Destroy(gameObject);

        }
    }
}
