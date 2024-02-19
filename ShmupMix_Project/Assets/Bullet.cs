using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public Vector2 direction = new Vector2(1, 0); //moving at: x=1 & y=0
    public float speed = 2;

    public Vector2 velocity;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 3); //bullet gets destroyed after 3 secs 
    }

    // Update is called once per frame
    void Update()
    {
        velocity = direction * speed; 
    }

    private void FixedUpdate()
    {
        Vector2 pos = transform.position;

        pos += velocity * Time.fixedDeltaTime;

        transform.position = pos; 
    }
}