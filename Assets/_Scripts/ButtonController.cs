//
//  Game Name: AvatarClash
//  Source File Name : ButtonController.cs
//  Author’s Name : Dipal Patel (301090880), Loveleen Kaur (301093331) , Bhavya Shah (301076681)
//  Date Last Modified : 13 April 2020
//  Program Description : Button Actions perfromed here
//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    // go back to start menu
    public void onBack_click(){
        SceneManager.LoadScene("Start");
    }

    // go back to main screen
    public void onPlayAgainButton_click(){
        SceneManager.LoadScene("Main");
    }

    // go back to home page
    public void onHomeButton_click(){
        SceneManager.LoadScene("Start");
    }

    // go back to instruction page
    public void onInstructionButton_click(){
        SceneManager.LoadScene("Instruction");
    }

    // go back to play screen 
    public void onLevelButton_click(){
        SceneManager.LoadScene("Main");
    }


    // take the user to level screen
    public void onPlayButton_click(){
        SceneManager.LoadScene("Level");
    }
}
