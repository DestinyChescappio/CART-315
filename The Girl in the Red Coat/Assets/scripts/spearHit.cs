using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spearHit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log(col.collider.name);
        if (col.collider.name == "caribou")
        {
            SceneManager.LoadScene("caribouCoat");
        }
    }
}

