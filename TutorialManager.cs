using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    public GameObject tutorial;
    public static bool tutorialPassed = false;

    void Update(){
        if(tutorialPassed){
            tutorial.SetActive(false);
        }

        if(Input.GetKeyDown(KeyCode.Return)){
            tutorial.SetActive(false);
            tutorialPassed = true;
        }
    }
}
