using UnityEngine;

public class Following : MonoBehaviour
{

    public float follow;
    public float followSpeed = 9f;
    public int targetPoint;
    public Transform[] Points;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        targetPoint = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, Points[targetPoint].position) <= 0.1)
        {
            increaseTargetInt();
        }
        transform.position = Vector2.Lerp(transform.position, Points[targetPoint].position, followSpeed * Time.deltaTime);
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
