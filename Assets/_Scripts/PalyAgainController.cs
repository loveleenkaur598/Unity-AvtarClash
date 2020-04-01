using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PalyAgainController : MonoBehaviour
{
    public void onPlayAgainButton_click(){
        SceneManager.LoadScene("Main");
    }
}
