
using System.Windows.Input;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Controller : MonoBehaviour
{
    private float moveSpeed = 7f;
    private float speedX, speedY, speedZ;
    public InputAction PlayControls;
    public BallModified modified;

    Vector2 moveDirection = Vector2.zero;
    private bool isDead = false;

    private void OnEnable()
    {
        PlayControls.Enable();
    }

    private void OnDisable()
    {
        PlayControls.Disable();
    }

    [SerializeField] Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveDirection = PlayControls.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }

    private void rein ()
    {
        isDead = true;
        if (modified != null)
            modified.OnPlayerDeath(); //calls shooting type
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            rein();
        }
    }
}
