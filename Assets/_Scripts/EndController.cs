using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndController : MonoBehaviour
{

    public Text ScoreLabel;
    public GameController gameController;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(gameController._score.ToString());
        ScoreLabel.text = "Score : " + gameController._score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
