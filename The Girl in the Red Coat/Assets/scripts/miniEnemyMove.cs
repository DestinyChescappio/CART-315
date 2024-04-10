using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class miniEnemyMove : MonoBehaviour
{
    public float moveSpeed;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void FixedUpdate()
    {
        Vector2 pos = transform.position;

        pos.x -= moveSpeed * Time.fixedDeltaTime;

        //enemy goes away after some time 
        if (pos.x < -20)
        {
            //  Destroy(gameObject);
            Vector2 resetPosition = new Vector2(1, transform.position.y);
            transform.position = resetPosition;

        }
        else
        {

            transform.position = pos;
        }
    }
}
