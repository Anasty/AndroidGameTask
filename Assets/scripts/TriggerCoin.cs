using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCoin : MonoBehaviour
{


    RandomCoins coins;

    public void Start()
    {
        coins = GameObject.Find("GenerateCoin").GetComponent<RandomCoins>();
    }

    public void OnTriggerEnter(Collider coll)
    {
        if (this.tag == "coin")
        {           
            coins.score++;
            Destroy(gameObject);
        }
    }
}
