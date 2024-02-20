using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 
public class FishyHealth : MonoBehaviour
{
    public float health;
    public float maxHealth;
    public Image healthBar; 
    // Start is called before the first frame update
    void Start()
    {
        maxHealth = health;
    }

    // Update is called once per frame
    void Update()
    {
        //using fill amount for health + maxHealth
        healthBar.fillAmount = Mathf.Clamp(health / maxHealth, 0, 1);

        //if(healthBar.fillAmount < 0.9)
        //{
        //  SceneManager.LoadScene("LoserScene");
        //}
    }

   
}
