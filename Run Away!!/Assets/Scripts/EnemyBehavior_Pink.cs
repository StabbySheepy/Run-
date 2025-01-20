using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior_Pink : MonoBehaviour
{
    public float EnemySpeed = 5f;
    public GameObject player;
    private float distance;  

    void Update() {
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;

        transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, EnemySpeed * Time.deltaTime); 
    }
}

