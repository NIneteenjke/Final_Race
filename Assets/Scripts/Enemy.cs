﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public  float speed;
    private Vector2Int carGridPosition;
    public GameObject bottomEnemy;
    public GameObject enemyGameObject;
    public GameObject enemyGameObject2;
    public static int score;
    public static int maxScore;
    public static int maxSpeed = 150;
    public static int minScore = 10;
    public GameObject drygoi1;
    public GameObject drygoi2;
    public GameObject drygoi3;
    public GameObject drygoi4;
    public Text TextScore;
    private Back script1;
    private Back script2;
    private Back script3;
    private Back script4;
    
    void Start()
    {   
        maxScore=100;
        score=0;
        speed = 400;
         enemyGameObject.transform.position = new Vector3(0f + Random.Range(-200f, 200f), transform.position.y+2000);
         enemyGameObject2.transform.position = new Vector3(0f + Random.Range(-200f, 200f), transform.position.y+1000);//появление противника 
    }


   

    void Update()
    {
        
        script1 = drygoi1.GetComponent<Back>();
        script1.speed = speed;
        script2 = drygoi2.GetComponent<Back>(); //увеличение сокрости дороги вместе с противником 
        script2.speed = speed;
        script3 = drygoi3.GetComponent<Back>();
        script3.speed = speed;
        script4 = drygoi4.GetComponent<Back>();
        script4.speed = speed;

        TextScore.text= score.ToString();
        enemyGameObject.transform.Translate(Vector3.down * speed * Time.deltaTime);
        enemyGameObject2.transform.Translate(Vector3.down * speed * Time.deltaTime);//движение протиника вниз

        if (enemyGameObject.transform.position.y < bottomEnemy.transform.position.y+4.4f)
        {
            enemyGameObject.transform.position = new Vector3(0f + Random.Range(-220f, 220f), enemyGameObject.transform.position.y+2004); //перемещение противника
    
            score += minScore;

            if (score == maxScore)
            {
                
                speed += maxSpeed;
                maxScore += 100;
                maxSpeed += 70;
            }
            if(PlayerPrefs.HasKey("score"))
            {
            PlayerPrefs.SetInt("score",score);
            PlayerPrefs.Save();
            }
            

            if (score == 600)
            {
                minScore += 5;
            }
            
           
        }
        if (enemyGameObject2.transform.position.y < bottomEnemy.transform.position.y+4.4f)
        {
            enemyGameObject2.transform.position = new Vector3(0f + Random.Range(-220f, 220f), enemyGameObject2.transform.position.y+2004);
            

            score += minScore;
           
            if (score == maxScore)
            {
                
                speed += maxSpeed;
                maxScore += 100;
                maxSpeed += 70;
            }
            if(PlayerPrefs.HasKey("score"))
            {
            PlayerPrefs.SetInt("score",score);
            PlayerPrefs.Save();
            }
            

            if (score == 600)
            {
                minScore += 5;
            }
            
           
        }
        
    }
}
