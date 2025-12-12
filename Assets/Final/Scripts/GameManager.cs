using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public BallModified modified;
    public DoubleShot twoshot;
    public ThreeWay threeshot;
    private bool isDead;
    private int currentBallIndex = 0;
    private PlayerMovement playerMovement;
    private SpriteRenderer playerSprite;
    private Collider2D playerCollider;
    private GameObject player;


    private void Start()
    {
        if (player == null)
        {
            player = GameObject.FindWithTag("Player");
            if (player == null)
            {
                Debug.LogWarning("Player not assigned and no GameObject with tag 'Player' found.");
                return;
            }
        }

        playerSprite = player.GetComponent<SpriteRenderer>();
        playerCollider = player.GetComponent<Collider2D>();
        playerMovement = player.GetComponent<PlayerMovement>();

        if (playerMovement != null)
        {
            if (playerMovement.gameManager == null)
                playerMovement.gameManager = this;
        }


        ApplyBulletByIndex(currentBallIndex);

    }

    public void PlayerDied()
    {
        rein();
    }

    private void rein()
    {
        if (isDead) return;
        isDead = true;

        if (currentBallIndex == 0 && modified != null)
        {
            modified.OnPlayerDeath();
        }

        else if (currentBallIndex == 1 && twoshot != null)
        {
            twoshot.OnPlayerDeath();
        }

        else if (currentBallIndex == 2 && threeshot != null)
        {
            threeshot.OnPlayerDeath();
        }

        currentBallIndex = (currentBallIndex + 1) % 3;
        ApplyBulletByIndex(currentBallIndex);

        StartCoroutine(RespawnRoutine());
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (isDead && collision.gameObject.CompareTag("Enemy"))
        {
            rein();
        }
    }

    private void CycleBullet()
    {
        currentBallIndex = (currentBallIndex + 1) % 3;
        ApplyBulletByIndex(currentBallIndex);
    }

    private IEnumerator RespawnRoutine()
    {
        if (playerSprite != null) playerSprite.enabled = false;
        if (playerCollider != null) playerCollider.enabled = false;
        if (playerMovement != null) playerMovement.enabled = false;

        if (player != null)
        {
            var rb = player.GetComponent<Rigidbody2D>();
            if (rb != null) rb.linearVelocity = Vector2.zero;
        }



        if (playerMovement != null)
        {
            playerMovement.Health = 1;
            playerMovement.enabled = true;
        }

        if (playerSprite != null) playerSprite.enabled = true;
        if (playerCollider != null) playerCollider.enabled = true;

        isDead = false;

        yield break;
    }

    private void ApplyBulletByIndex (int idx)
    {
        if (modified != null)
        {
            if (idx == 0) modified.enabled = true;
            else modified.enabled = false;
        }

        if (twoshot != null)
        {
            if (idx == 1) twoshot.enabled = true;
            else twoshot.enabled = false;
        }

        if (threeshot != null)
        {
            if (idx == 2) threeshot.enabled = true;
            else threeshot.enabled = false;
        }
    }

    public void OnPlayerRespawn()
    {
        isDead = false;
    }
}
