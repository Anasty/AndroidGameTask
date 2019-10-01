using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerCube : MonoBehaviour {

    RandomCoins coins;

    public static bool isFinish = false;


    public Text MainText;

    public void Start()
    {
        coins = GameObject.Find("GenerateCoin").GetComponent<RandomCoins>();
    }

    public void OnTriggerEnter(Collider coll)
    {
        isFinish = true;
        if (this.tag == "exit")
        {          
            if (GameTime.GameSeconds > 0)
                MainText.text = "Score: " + coins.score;
        }
    }
}
