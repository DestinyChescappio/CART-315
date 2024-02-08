﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour {
    private float     xPos;
    public float      paddleSpeed = .05f;
    public float      topWall, bottomWall;

    public KeyCode upKey, downKey;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKey(downKey)) {
            if (xPos > bottomWall) {
                xPos -= paddleSpeed;
            }
        }

        if (Input.GetKey(upKey)) {
            if (xPos < topWall) {
                xPos += paddleSpeed;
            }
        }

        transform.localPosition = new Vector3(transform.position.x, xPos, 0);
    }
}

