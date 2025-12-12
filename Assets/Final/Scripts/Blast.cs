using System;
using UnityEngine;
using System.Collections.Generic;

public class Blast : MonoBehaviour
{
    public Transform shootPoint;
    public GameObject prefabBullet;
    public GameObject Ball2;
    public GameObject Ball3;
    public GameObject Ball4;
    public GameManager IndexBall;
    void Start()
    {

        IndexBall = FindAnyObjectByType<GameManager>();
      prefabBullet.SetActive(true);
        Ball2.SetActive(false);
        Ball3.SetActive(false);
        Ball4.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(IndexBall.currentBallIndex == 0)
            {
                Instantiate(prefabBullet, shootPoint.position, transform.rotation);
            }
           
            
            if (IndexBall.currentBallIndex == 1)
            {

                Instantiate(Ball2, shootPoint.position, transform.rotation);
                prefabBullet.SetActive(false);
                Ball2.SetActive(true);
                Ball3.SetActive(false);
                Ball4.SetActive(false);

            }
            if (IndexBall.currentBallIndex == 2)
            {
                Instantiate(Ball3, shootPoint.position, transform.rotation);
                prefabBullet.SetActive(true);
                Ball2.SetActive(false);
                Ball3.SetActive(false);
                Ball4.SetActive(false);
            }
        }
        
    }
}
