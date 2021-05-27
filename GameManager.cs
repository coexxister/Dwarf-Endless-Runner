using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public GameObject gameOver;

    public void EndGame(){
        if(gameHasEnded == false){
            gameHasEnded = true;
            gameOver.SetActive(true);
        }
    }
}
