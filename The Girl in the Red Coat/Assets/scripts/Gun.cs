using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour

    
{
    public GameObject prefab;
    public GameObject spear;

    public void shoot()

    {
       
            GameObject bullet = Instantiate(prefab, transform.position, Quaternion.identity);
        

    }
    // Start is called before the first frame update
    void Start()
    {
        spear = this.gameObject.transform.GetChild(0).gameObject;
        //spear.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            

            if (spear.activeSelf == false)
            {
                shoot();
            }
            else {
                spear.GetComponent<spearMove>().shoot = true;
            }
        }

    }
}
