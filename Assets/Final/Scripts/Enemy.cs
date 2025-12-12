using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] int enemyHp = 3;
    int currentHP;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] int PlayerDamaged = 2;
    public PlayerMovement playMov;
    private void Start()
    {
     rb = GetComponent<Rigidbody2D>();
        currentHP = enemyHp;

        if (playMov == null)
            playMov = GameObject.FindWithTag("Player").GetComponent<PlayerMovement>();
    }
    public void TakeDamage(int damage)
    {
        currentHP -= damage;

        if (currentHP <= 0)
        {
            Die();
            Debug.Log("The enemy is dead.");
        }
    }

    void Die()
    {
        Destroy(gameObject);
        Debug.Log("The enemy is dead.");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playMov.TakeDamage(PlayerDamaged);
        }
    }

}
