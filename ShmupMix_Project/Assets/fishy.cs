using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishy : MonoBehaviour
{
    //array ofguns
    Gun[] guns;

    float moveSpeed = 3;
    public float leftWall, rightWall, topWall, bottomWall;

    //boolean actions
    bool moveUp;
    bool moveDown;
    bool moveLeft;
    bool moveRight;

    bool shoot;
    //bool speedUp; //only triggered if fish collides with star 



    // Start is called before the first frame update
    void Start()
    {
        guns = transform.GetComponentsInChildren<Gun>(); //the fishy recognizing the array 'children' of guns 
    }

    // Update is called once per frame
    void Update()
    {

        moveUp = Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W);

        moveDown = Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S);
        moveLeft = Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A);
        moveRight = Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D);

        shoot = Input.GetKeyDown(KeyCode.LeftControl);

    //checking if fishy shoots
    if (shoot)
        {
            shoot = false;
            foreach(Gun gun in guns)
            {
                gun.Shoot();
            }
        }

        
    }

    //moving in Action! 
    private void FixedUpdate()
    {
        Vector2 pos = transform.position;

        //how far to move frame
        float moveAmount = moveSpeed * Time.fixedDeltaTime;
        Vector2 move = Vector2.zero;

        if (moveUp)
        {
            move.y += moveAmount;
        }
        if (moveDown)
        {
            move.y -= moveAmount;
        }
        if (moveLeft)
        {
            move.x -= moveAmount;
        }
        if (moveRight)
        {
            move.x += moveAmount;
        }

        //diagonal movement Pythagorean theorem
        float moveMagnitude = Mathf.Sqrt(move.x * move.x + move.y * move.y);
        if (moveMagnitude > moveAmount)
        {
            float ratio = moveAmount / moveMagnitude;
            move *= ratio;
        }

        pos += move;

        //Boundaries (locking fishy inside screen)
        if (pos.x <= 1.5f)
        {
            pos.x = 1.5f;
        }
        if (pos.x >= 16f)
        {
            pos.x = 16;
        }
        if (pos.y <= 1)
        {
            pos.y = 1;
        }
        if (pos.y >= 9) //9 before
        {
            pos.y = 9;
        }



        transform.position = pos;

    }
}

