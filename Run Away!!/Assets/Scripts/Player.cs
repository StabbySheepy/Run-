using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
   public float PlayermoveSpeed = 5;
   public GameObject self; 
   public GameObject Enemy; 
   float ScaleValue;
   public GameObject Spawnpoint;  
   public GameObject EnemySpawnpoint; 
   public GameObject ShieldCircleFX; 
   public bool ShieldOn = false; 

    public TextMeshProUGUI timer; 

    public Animator animator; 

    public ParticleSystem sweatdrops; 
    public Collider2D circle; 
   
   void Start(){ 
    ShieldOn = false; 
    ShieldCircleFX.SetActive(false); 
    timer = GameObject.Find("Timer").GetComponent<Timer>().timerText;
    sweatdrops = GetComponent<ParticleSystem>();  
    circle = GetComponent<CircleCollider2D>(); 
   }

void FixedUpdate() {
     //Movement
     //Right
    if (Input.GetKey(KeyCode.D))
    {
        transform.position += Vector3.right * PlayermoveSpeed * Time.deltaTime;
        animator.SetBool("WR_Bool", true);
        animator.SetBool("WL_Bool", false);
        animator.SetBool("WB_Bool", false);
        animator.SetBool("WF_Bool", false);
    }
    //Left
    else if (Input.GetKey(KeyCode.A))
    { 
        transform.position += Vector3.right * -PlayermoveSpeed * Time.deltaTime; 
        animator.SetBool("WR_Bool", false);
        animator.SetBool("WL_Bool", true);
        animator.SetBool("WB_Bool", false);
        animator.SetBool("WF_Bool", false); 
    }
    //Back
    else if (Input.GetKey(KeyCode.W))
    {
        transform.position += Vector3.up * PlayermoveSpeed * Time.deltaTime;
        animator.SetBool("WR_Bool", false);
        animator.SetBool("WL_Bool", false);
        animator.SetBool("WB_Bool", true);
        animator.SetBool("WF_Bool", false);
    }
    //Forward
    else if (Input.GetKey(KeyCode.S))
    {
        transform.position += Vector3.up * -PlayermoveSpeed * Time.deltaTime;
        animator.SetBool("WR_Bool", false);
        animator.SetBool("WL_Bool", false);
        animator.SetBool("WB_Bool", false);
        animator.SetBool("WF_Bool", true); 
    }

    
}
//Collision Checker
void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.CompareTag("Enemy")) {
        //kill player
            self.transform.position = Spawnpoint.transform.position; 
            SceneManager.LoadScene("You Lose");   
        }
        

    }

    void OnTriggerEnter2d(Collider2D uhohcircle){
            if(uhohcircle.gameObject.CompareTag("Enemy")){
                //particles start
                sweatdrops.Play();  
            }
    }

}
