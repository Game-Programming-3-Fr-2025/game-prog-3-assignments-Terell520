using Unity.VisualScripting;
using UnityEngine;
using System;
using System.Collections.Generic;
public class Enemy : MonoBehaviour
{
    [SerializeField] int enemyHp = 3;
    int currentHP;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] int PlayerDamaged = 2;
    public PlayerMovement playMov;
    public GameManager BallIndexed;
     void Start()
     {
        BallIndexed = FindFirstObjectByType<GameManager>();
     }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameObject.CompareTag("Player"))
        {
            BallIndexed.currentBallIndex += 1;
        }
    }

}
