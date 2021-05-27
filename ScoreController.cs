using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public double score;
    public Text scoreDisplay;
    public Text highScoreDisplay;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreDisplay.text = ((int)score).ToString();
        highScoreDisplay.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(TutorialManager.tutorialPassed){
        if(!ObstacleController.isHit){
            score += 0.1;
        }
        
        scoreDisplay.text = ((int)score).ToString();

        if(score > PlayerPrefs.GetInt("HighScore",0)){
            PlayerPrefs.SetInt("HighScore", (int)score);
        }
        }
    }
}
