using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text TextScore;
    public int score;

    public Color color = new Color(79, 24, 125, 255);

    void Start()
    {
        
        score=PlayerPrefs.GetInt("score");
    }

    void Update()
    {   
        
        TextScore.text= score.ToString();
    }
    
}
