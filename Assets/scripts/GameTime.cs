using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTime : MonoBehaviour
{

    public static float GameSeconds = 60f;

    string stringSeconds;

    public Text textTime;
    public Text MainText;



    // Update is called once per frame
    void Update()
    {
        if (GameSeconds > 0f && !TriggerCube.isFinish)
        {
            GameSeconds = GameSeconds - Time.deltaTime;
            stringSeconds = GameSeconds.ToString();
            textTime.text = "Осталось - " + stringSeconds + " сек";            
        }
        else if(GameSeconds <= 0f)
        {          
            MainText.text = "GameOver";
        }
    }
}
