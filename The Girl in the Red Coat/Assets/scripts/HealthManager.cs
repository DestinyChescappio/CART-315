using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class HealthManager : MonoBehaviour
{
    public Image healthBar;
    public float healthAmount;
    //public Wapinoo_health pHealth; 

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      
    }


        //when enemy touches player function passing through a float called damage - adjust this later on for if player touches enemy !!!
        public void TakeDamage(float damage)
        {
            //health amoount is decreased
            healthAmount -= damage;
            //the fill amount is divided by the max health 100f
            healthBar.fillAmount = healthAmount / 100f;

        Debug.Log(healthAmount);
        }


    //When the player heals - opposite of damage function - adjust this later on for if player touches Lab tea, cedar, sage + water or fire !!!
    public void Heal(float healingAmount)
    {
        healthAmount += healingAmount;
        healthAmount = Mathf.Clamp(healthAmount, 0, 100);

        healthBar.fillAmount = healthAmount / 100f;
    }
}
