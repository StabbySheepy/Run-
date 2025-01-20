using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 
using UnityEngine.SceneManagement; 

public class Timer : MonoBehaviour
{
    public float targetTime = 10f;
    public TextMeshProUGUI timerText; 
    
    void Start(){  
    }
    void Update(){ 

        if (targetTime <= 0){
            timerEnded();
        }
        double b = System.Math.Round(targetTime,1); 
        timerText.text = b.ToString();
        targetTime -= Time.deltaTime;

    }

    void timerEnded()
    {
        SceneManager.LoadScene("You Win");    
    }
}
