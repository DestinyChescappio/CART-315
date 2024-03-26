using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
   
    public float moveSpeed;
    public int EnemySpeed;

    //public int XMoveDirection;

    private Transform wapinoo;
    private Rigidbody2D rb; 


    // Start is called before the first frame update
    void Start()
    {
        wapinoo = GameObject.FindGameObjectWithTag("Player").transform;
        rb = GetComponent<Rigidbody2D>();
    }

     void Update()
    {
        if (wapinoo != null)
        {
        //direction of enemy going to wapinoo 
        Vector2 direction = new Vector2(wapinoo.position.x - transform.position.x, 0).normalized;
            //velocity of enemy following wapinoo oh no!
            rb.velocity = direction * EnemySpeed;
    }

    }
}