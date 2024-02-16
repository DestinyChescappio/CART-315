using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreScript : MonoBehaviour
{
    public Text scoreText;
    public int score;

    public static scoreScript S;

    void Awake()
    {
        S = this; 
    }

    // Start is called before the first frame update
    void Start()
    {
        score = -1;
        //UpdateScore(); 
    }

    public void UpdateScore()
    {
        score += 1;
        string scoreDisplay
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        scoreText.text = "Score" + score.ToString(); 
    }
}
