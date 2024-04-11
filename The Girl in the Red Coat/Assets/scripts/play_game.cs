using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class play_game : MonoBehaviour
{

    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void OnMouseDown()
    {
        StartGame();
    }
}
