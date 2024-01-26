using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bedController : MonoBehaviour
{
    
    public SpriteRenderer sr;
    public string str;
    public float score; 
    public float xLoc = 0;
    public float bedSpeed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        sr = this.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z) && xLoc > -9f)
            xLoc -= bedSpeed;
        {
            if (Input.GetKeyDown(KeyCode.X) && xLoc < 9f)
                xLoc += bedSpeed;
        }
        this.transform.position = (Vector3)new Vector3(xLoc,
            transform.position.y, transform.position.z);
        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.name == "Sleepy") score += 1;
        else score -= 1;

        Destroy(other.gameObject);
    }
}
