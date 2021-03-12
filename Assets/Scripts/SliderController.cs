using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    public Slider slider;
    public float oldVolume;
    private void Start()
    {
        oldVolume=slider.value;
        if(PlayerPrefs.HasKey("Volume")) slider.value=1;
        else slider.value=PlayerPrefs.GetFloat("Volume");
    }

   
    private void Update()
    {
       if(oldVolume !=slider.value)
       {
           PlayerPrefs.SetFloat("Volume", slider.value);
           PlayerPrefs.Save();
           oldVolume=slider.value;
       } 
    }
}
