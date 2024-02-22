using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreTracker : MonoBehaviour
    
{
    public TMP_Text score;
    public int scoreValue = 0;
    // Start is called before the first frame update
    void Start()
    {
        score.text = scoreValue.ToString();
        Debug.Log(score.text);
    }

    private void Update()
    {
        score.text = scoreValue.ToString();
        if (scoreValue >= 12)
        {
            SceneManager.LoadScene("WinnerScene");

        }
    }


}
