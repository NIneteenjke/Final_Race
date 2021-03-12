using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource audio;
    
    private void Start()
    {
        if(PlayerPrefs.HasKey("Volume")) audio.volume=1;   
    }
    private void Update()
    {
        audio.volume=PlayerPrefs.GetFloat("Volume"); 
    }
}
