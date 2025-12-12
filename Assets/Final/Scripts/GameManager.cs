using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    private bool isDead;
    public int currentBallIndex;
    private PlayerMovement playerMovement;
    private SpriteRenderer playerSprite;
    private Collider2D playerCollider;
    private GameObject player;


    private void Start()
    {
        currentBallIndex = 0;
    }
        
        public void OnPlayerRespawn()
         {
        isDead = false;
         }
}
