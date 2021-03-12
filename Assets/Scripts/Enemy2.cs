using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    // public int GlobalSpeed;
    public  float speed;
    private Vector2Int carGridPosition;
    public GameObject bottomEnemy;
    public GameObject enemyGameObject;
    public static int score;
    public static int maxScore = 150;
    public static int maxSpeed = 150;
    public static int minScore = 10;

    void Start()
    {
        score=0;
        speed = 400;
        transform.position = new Vector3(0f + Random.Range(-2f, 2f), transform.position.y);
    }



    void Update()
    {
        
       
        
        transform.Translate(Vector3.down * speed * Time.deltaTime);//движение вниз противника 

        if (transform.position.y < bottomEnemy.transform.position.y+4.4f)
        {
            transform.position = new Vector3(0f + Random.Range(-200f, 200f), transform.position.y+2004);
            if (score == maxScore)
            {
                Debug.Log("Есть");
                speed += maxSpeed;
                maxScore += 150;
                maxSpeed += 150;
            }

            score += minScore;
            // GlobalSpeed += maxSpeed;
            Debug.Log(score);
            if (score == 600)
            {
                minScore += 5;
            }
            // PlayerPrefs.SetInt("score",score);
            // PlayerPrefs.Save();
           
        }
        
    }
}

