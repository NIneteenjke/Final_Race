﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    public float speed;
    public GameObject Left;
    public GameObject Right;
    public int score;
    private bool paused = false;
    public GameObject panel;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!paused)
            {
                Time.timeScale = 0;
                paused = true;
                panel.SetActive(true);
               
            }
            else
            {
                Time.timeScale = 1;
                paused = false;
                panel.SetActive(false);
            
            }
        }
    

       
        if (Input.GetKey(KeyCode.LeftArrow)) 
        {
            if (transform.position.x > Left.transform.position.x)
            {
                transform.Translate(Vector2.left * speed * Time.deltaTime);     //перемещение персонажа
            }   
        }
        else if (Input.GetKey(KeyCode.RightArrow)) 
        {
            if (transform.position.x < Right.transform.position.x)
            {
                transform.Translate(Vector2.right * speed * Time.deltaTime);
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision) //конец игры
    {
        
        Destroy(gameObject);
        SceneManager.LoadScene(3);
    }
}