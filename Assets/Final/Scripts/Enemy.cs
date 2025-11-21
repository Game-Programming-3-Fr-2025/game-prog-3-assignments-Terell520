using UnityEngine;

public class Enemy : MonoBehaviour
{
    private int enemyHp = 1;
    public Rigidbody2D rb;
    // Update is called once per frame

    private void Start()
    {
     rb = GetComponent<Rigidbody2D>();
    }
    public void TakeDamage(int damage)
    {
        
    }
}
