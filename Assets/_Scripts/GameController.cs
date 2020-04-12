using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[System.Serializable]

public class GameController : MonoBehaviour
{

    [Header("Coin Configuration")]
    public Transform coinContainer;
    public int coinNum = 3;
    public GameObject coin;

    public List<GameObject> coins;

    [Header("Spinner Configuration")]
    public Transform spinnerContainer;
    public int spinnerNum;
    public GameObject spinner;

    public List<GameObject> spinners;

    [Header("LandSpike Configuration")]
    public Transform landSpikeContainer;
    public int landSpikeNum;
    public GameObject landSpike;

    public List<GameObject> landSpikes;

    [Header("ScoreBoard")]

    public Text LivesLabel;
    public Text ScoreLabel;

    // private instance memeber
    private int _score;
    private int _lives;

    // public properties
    public int Score
    {
        get { return _score; }
        set 
        { 
            _score = value; 
            ScoreLabel.text = "Score : " +  _score.ToString();
            
        }
    }
    public int Lives
    {
        get { return _lives; }
        set 
        { 
            _lives = value;
            LivesLabel.text = "Lives : " +  _lives.ToString();
            if(_lives <1)
            {
                SceneManager.LoadScene("End");
            }
        }
    }
    

    // Start is called before the first frame update
    void Start()
    {
        coins = new List<GameObject>();// empty list of type gameObject
        spinners = new List<GameObject>();// empty list of type gameObject
        _buildCoinList();

        _buildSpikesAndSpinnersList();

        Lives = 5;
        Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void _buildCoinList(){
        for (int count = 0; count < coinNum; count++)
        {
            var newCoin = Instantiate(coin);
            newCoin.transform.parent = coinContainer.transform;
            coins.Add(newCoin);
        }
    }

    private void _buildSpikesAndSpinnersList(){
        for (int count = 0; count < spinnerNum; count++)
        {
            var newSpinner = Instantiate(spinner);
            newSpinner.transform.parent = spinnerContainer.transform;
            spinners.Add(newSpinner);
        }
        for (int count = 0; count < landSpikeNum; count++)
        {
            var newLandSpike = Instantiate(landSpike);
            newLandSpike.transform.parent = landSpikeContainer.transform;
            landSpikes.Add(newLandSpike);
        }
    }
}
