using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletDamage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)

    {

        if (other.gameObject.CompareTag("Enemy")) //if bullet collides with this object
        {

            Destroy(other.gameObject);


        }

    }
}
