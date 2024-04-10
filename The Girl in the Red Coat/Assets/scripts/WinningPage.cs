using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinningPage : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("start");
    }
}
