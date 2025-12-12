using UnityEngine;

public class ThreeWay : MonoBehaviour
{
    private float speed = 250;
    [SerializeField] Rigidbody2D rb;
    private int appliedDamage = 1;

    private void Update()
    {

    }
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
    void OnBecomeInvisible()
    {
        Destroy(gameObject);
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
