using UnityEngine;

public class Following : MonoBehaviour
{

    public float follow;
    public float followSpeed = 9f;
    public int targetPoint;
    public Transform[] Points;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] Rigidbody2D rb;
    private void Start()
    {
        targetPoint = 0;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Vector2.Distance(transform.position, Points[targetPoint].position) <= 0.1)
        {
            increaseTargetInt();
        }
        Vector2 direction = (Points[targetPoint].position - transform.position).normalized;
        rb.MovePosition((Vector2)transform.position + (direction * followSpeed * Time.fixedDeltaTime));
    }
    void increaseTargetInt()
    {
        targetPoint++;
        if (targetPoint >= Points.Length)
        {
            targetPoint = 0;
        }
    }
}
