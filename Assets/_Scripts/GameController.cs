using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public Transform coinContainer;
    public Transform spinnerContainer;
    public GameObject coin;
    public GameObject spinner;

    public int coinNum;
    public int spinnerNum;

    public List<GameObject> coins;
    public List<GameObject> spinners;
    // Start is called before the first frame update
    void Start()
    {
        coins = new List<GameObject>();// empty list of type gameObject
        spinners = new List<GameObject>();// empty list of type gameObject
        _buildCoinList();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void _buildCoinList(){
        for (int count = 0; count < coinNum; count++)
        {
            var newCoin = Instantiate(coin);
            newCoin.transform.parent = coinContainer.transform;
            coins.Add(newCoin);
        }
        for (int count = 0; count < spinnerNum; count++)
        {
            var newSpinner = Instantiate(spinner);
            newSpinner.transform.parent = spinnerContainer.transform;
            spinners.Add(newSpinner);
        }
    }
}
