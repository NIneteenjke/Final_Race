using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTest3 : MonoBehaviour
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
    private Back script1;
    private Back script2;
    private Back script3;
    private Back script4;

    void Start()
    {   
        maxScore=100;
        score=0;
        speed = 400;
        // enemyGameObject.transform.position = new Vector3(0f + Random.Range(-200f, 200f), transform.position.y);
        // enemyGameObject2.transform.position = new Vector3(0f + Random.Range(-200f, 200f), transform.position.y);
    }


    void OnGUI()
    {
        string t= score.ToString();
        GUI.skin.label.fontSize = 30;
        GUI.color = Color.black;
        GUI.Label(new Rect(Screen.width -100, 55, 200, 200), t);
    }

    void Update()
    {
        
        script1 = drygoi1.GetComponent<Back>();
        script1.speed = speed;
        script2 = drygoi2.GetComponent<Back>();
        script2.speed = speed;
        script3 = drygoi3.GetComponent<Back>();
        script3.speed = speed;
        script4 = drygoi4.GetComponent<Back>();
        script4.speed = speed;

        
        enemyGameObject.transform.Translate(Vector3.down * speed * Time.deltaTime);//движение вниз противника 
        enemyGameObject2.transform.Translate(Vector3.down * speed * Time.deltaTime);//движение вниз противника 

        if (enemyGameObject.transform.position.y < bottomEnemy.transform.position.y+4.4f)
        {
            enemyGameObject.transform.position = new Vector3(0f + Random.Range(-220f, 220f), enemyGameObject.transform.position.y+2004);
    
            score += minScore;

            if (score == maxScore)
            {
                Debug.Log("Есть");
                speed += maxSpeed;
                maxScore += 150;
                maxSpeed += 150;
            }
            if(PlayerPrefs.HasKey("score"))
            {
            PlayerPrefs.SetInt("score",score);
            PlayerPrefs.Save();
            }
            

            if (score == 130)
            {
                minScore += 5;
            }
            
           
        }
        if (enemyGameObject2.transform.position.y < bottomEnemy.transform.position.y+20)
        {
            enemyGameObject2.transform.position = new Vector3(0f + Random.Range(-220f, 220f), enemyGameObject2.transform.position.y+2004);
            

            score += minScore;
           
            if (score == maxScore)
            {
                Debug.Log("Есть");
                speed += maxSpeed;
                maxScore += 150;
                maxSpeed += 150;
            }
            if(PlayerPrefs.HasKey("score"))
            {
            PlayerPrefs.SetInt("score",score);
            PlayerPrefs.Save();
            }
            

            if (score == 130)
            {
                minScore += 5;
            }
            
           
        }
        
    }
}

