using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footsteps : MonoBehaviour
{
    public AudioSource beepboop; 

    void Update(){
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)){
            beepboop.enabled = true; 
        }
        else{
            beepboop.enabled = false; 
        }
    }
}
