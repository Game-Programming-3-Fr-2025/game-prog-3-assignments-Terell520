using UnityEngine;
using System;
using System.Collections.Generic;
public class Balls : MonoBehaviour
{
    public GameObject Ball;
    public GameObject Ball2;
    public GameObject Ball3;
    public GameObject Ball4;
    public GameManager Index;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Index=GetComponent<GameManager>();
        Ball.SetActive(true);
        Ball2.SetActive(false);
        Ball3.SetActive(false);
        Ball4.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Index.currentBallIndex ==0)
        {
            Ball.SetActive(true);
            Ball2.SetActive(false);
            Ball3.SetActive(false);
            Ball4.SetActive(false);
        }
        if (Index.currentBallIndex == 1)
        {
            Ball.SetActive(false);
            Ball2.SetActive(true);
            Ball3.SetActive(false);
            Ball4.SetActive(false);
        }
    }
}
