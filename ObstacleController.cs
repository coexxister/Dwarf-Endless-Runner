using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    public static bool isHit = false;

    void OnTriggerEnter2D(Collider2D obstacle){
        if(obstacle.CompareTag("Player")){
            isHit = true;
            Destroy(gameObject);
        }
    }
}
