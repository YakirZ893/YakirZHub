using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;


using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int score = 0;
    public Text scoretext;




    public void Addscore(int ScoreAmount)
    {
        score = score + ScoreAmount;
        scoretext.text = "Score:" + score.ToString();
        if (score > 0)
            scoretext.color = Color.green;
        else
        {
            scoretext.color = Color.black;
        }


    }
    public void subtractscore(int ScoreReduce)
    {
        score = score + ScoreReduce;
        if (score < 0)
            scoretext.color = Color.red;
        else
        {
            scoretext.color = Color.black;
        }
        scoretext.text = "Score:" + score.ToString();

    }
}
