using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomCoins : MonoBehaviour {

    public Transform coin;
    int count = 50;
    public int score = 0;

    public Text CoinText;

    private Vector3 mapSize = new Vector3(150, 1, 150);

	// Use this for initialization
	void Start () {

        GenerateCoin();

    }

    private void Update()
    {
        CoinText.text = "Score: " + score;
    }

    void GenerateCoin() {
        for (int i = 0; i < count; i++)
        {
            Instantiate(coin, new Vector3(Random.Range(0, mapSize.x),1, Random.Range(0, mapSize.z)), coin.rotation);
        }
    }

}
