using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    public void onBack_click(){
        SceneManager.LoadScene("Start");
    }

    public void onPlayAgainButton_click(){
        SceneManager.LoadScene("Main");
    }

    public void onHomeButton_click(){
        SceneManager.LoadScene("Start");
    }

    public void onInstructionButton_click(){
        SceneManager.LoadScene("Instruction");
    }

    public void onLevelButton_click(){
        SceneManager.LoadScene("Main");
    }

    public void onPlayButton_click(){
        SceneManager.LoadScene("Level");
    }
}
