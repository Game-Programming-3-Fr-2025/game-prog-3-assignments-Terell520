using UnityEngine;

public class GameManager : MonoBehaviour
{
    public BallModified modified;
    public DoubleShot twoshot;
    public ThreeWay threeshot;
    private bool isDead;
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
