using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldPickup : MonoBehaviour
{
    public bool Shield;
    public GameObject ShieldFX; 

    public void Start(){
        Shield = GameObject.Find("Player").GetComponent<Player>().ShieldOn;
        ShieldFX = GameObject.Find("Player").GetComponent<Player>().ShieldCircleFX;
    }
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.tag == "Player"){ 
            Debug.Log("Pickup"); 
            Destroy(gameObject);
            Shield = true; 
            ShieldFX.SetActive(true);
        }
    }
}
