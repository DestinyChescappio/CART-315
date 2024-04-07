using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wapino_move : MonoBehaviour
{
    public int playerSpeed = 10;
    private bool facingRight = false;
    public int playerJumpPower = 1250;
    private float moveX;
    public bool isGrounded;
    public bool fireCollected = false;
    public bool sageCollected = false;

    public bool rockCollected = false;
    public bool branchCollected = false; 

    public GameObject HealthManager;

    public GameObject spear;
    // Start is called before the first frame update
    void Start()
    {
        spear = this.gameObject.transform.GetChild(0).gameObject;
        spear.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();

        if (rockCollected == true && branchCollected == true)
        {
            spear.SetActive(true);
        }
       
    }
    void PlayerMove()
    {
        //controls
        moveX = Input.GetAxis("Horizontal");
        if(Input.GetButtonDown("Jump") && isGrounded == true)
        {
            Jump();
        }
     //animations
     //player direction
        if (moveX < 0.0f && facingRight == false)
        {
            FlipPlayer();
        }
        else if (moveX > 0.0f && facingRight == true)
        {
            FlipPlayer();
        }
        //physics (left & right moving)
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
    }

    void Jump()
    {
        //player jumping
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * playerJumpPower);
        isGrounded = false;
    }

    void FlipPlayer()
    {
        facingRight = !facingRight;
        Vector2 localScale = gameObject.transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }

    void increaseHealth()
    {
        
        if (fireCollected == true && sageCollected == true)
        {
            HealthManager.GetComponent<HealthManager>().Heal(20);
        }
    }

    void OnCollisionEnter2D (Collision2D col)
    {
        Debug.Log("player has collided with" + col.collider.name);
        if (col.gameObject.tag == "ground")
        {
            isGrounded = true; 
        }

        if (col.collider.name == "firePrefab")
        {
            fireCollected = true;
            increaseHealth();
            
        }
        if (col.collider.name == "sagePrefab")
        {
            sageCollected = true;
            increaseHealth();
            
        }
        if (col.collider.name == "rock")
        {
            rockCollected = true;

        }
        if (col.collider.name == "branch")
        {
            branchCollected = true; 
        }
        //if (col.collider.name == "waterPrefab")
        //{
        //    sageCollected += 1;
        //    increaseHealth();
        //}
        //if (col.collider.name == "cedarPrefab")
        //{
        //    sageCollected += 1;
        //    increaseHealth();
        //}

    }
}
