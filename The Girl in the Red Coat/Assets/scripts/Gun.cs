using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour

    
{
    public GameObject prefab;
   

    public void shoot()

    {
       
            GameObject bullet = Instantiate(prefab, transform.position, Quaternion.identity);
        

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            shoot();
        }

    }
}
