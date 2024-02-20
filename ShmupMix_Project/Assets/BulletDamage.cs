using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamage : MonoBehaviour

{
    

    public GameObject gameManager; 
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("gameManager");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)

    {
       
        if (other.gameObject.CompareTag("Enemy")) //if fishy collides with this object
        {
           
            Destroy(other.gameObject);

            gameManager.GetComponent<ScoreTracker>().scoreValue++;
            

        }

    }

}
