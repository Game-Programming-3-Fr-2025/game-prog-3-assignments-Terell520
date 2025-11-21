
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
    private bool isDead;
    //private ModifiedBullet bullet;
    private Vector2 moveDirection = Vector2.zero;
    //private bool isDead = false;

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

private void rein()
    {
        if (isDead) return;
        isDead = true;

        if (modified != null)
            modified.OnPlayerDeath();

        //if (bullet != null)
            //bullet.OnPlayerDeath();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (isDead && collision.gameObject.CompareTag("Enemy"))
        {
            rein();
        }
    }
}

