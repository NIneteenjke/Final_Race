using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back : MonoBehaviour
{
    public float speed;
    public GameObject bottomBG;
    public float backLenght;
    public int backCount;
    
    void Start()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        if (transform.position.y < bottomBG.transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + backLenght * backCount);      //перемещение фона
        }
        
    }
}

