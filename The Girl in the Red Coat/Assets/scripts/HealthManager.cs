using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class HealthManager : MonoBehaviour
{
    public Image healthBar;
    public float healthAmount; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (healthAmount <= 0)
        {
            SceneManager.LoadScene("SampleScene");
        }
        //if player is pressing return
        if (Input.GetKeyDown(KeyCode.Return))
        {
            //these functions happen 
            TakeDamage(20);

        }
        //if pressing space 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Heal(5);
        }
    }

    //when enemy touches player function passing through a float called damage - adjust this later on for if player touches enemy !!!
    public void TakeDamage(float damage)
    {
        //health amoount is decreased
        healthAmount -= damage;
        //the fill amount is divided by the max health 100f
        healthBar.fillAmount = healthAmount / 100f;
    }


    //When the player heals - opposite of damage function - adjust this later on for if player touches Lab tea, cedar, sage + water or fire !!!
    public void Heal(float healingAmount)
    {
        healthAmount += healingAmount;
        healthAmount = Mathf.Clamp(healthAmount, 0, 100);

        healthBar.fillAmount = healthAmount / 100f;
    }
}
