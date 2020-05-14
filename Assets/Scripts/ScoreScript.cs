using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreScript : MonoBehaviour
{

    public int currentScore = 0;
    public int Killpoints = 50;
    public TextMeshProUGUI scoreText; //UI for score
    // Start is called before the first frame update


 


    void Start()
    {
        //Sets current score to 0 at launch 
        scoreText.text = "Score: " + currentScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }







    // Gets called to EnemyHit script
    public void AddtoScore()
    {
        currentScore += Killpoints;
        scoreText.text = "Score: " + currentScore.ToString();
    }

}
