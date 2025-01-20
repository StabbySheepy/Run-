using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinNoiseDelay : MonoBehaviour
{
    public AudioSource winsound;  
    public float timedelay;
    void Update(){
        if (timedelay <= 0){
            TimerEnded();
        }
        timedelay -= Time.deltaTime;
    }

    void TimerEnded(){
        winsound.Play(); 
    }
    
}
