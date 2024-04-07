using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spearMove : MonoBehaviour

{
    public Vector2 direction = new Vector2(1, 0); //moving at: x=1 & y=0
    public float speed = 5;

    public Vector2 velocity;
    public bool shoot = false; 


    // Start is called before the first frame update
    void Start()
    {
        //Destroy(gameObject, 4); //bullet gets destroyed after 3 secs 
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.activeSelf == true && shoot == true)
        {
            velocity = direction * speed;
        }
        

    }

    private void FixedUpdate()
    {
        
        if (this.gameObject.activeSelf == true && shoot == true)
        {
            Vector2 pos = transform.position;

            pos += velocity * Time.fixedDeltaTime;

            transform.position = pos;

        }
    }
}
