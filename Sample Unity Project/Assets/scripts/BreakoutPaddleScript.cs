﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakoutPaddleScript : MonoBehaviour {
    private float     xPos;
    public float      paddleSpeed = 5f;
    public float      leftWall, rightWall;

    public KeyCode upKey, downKey;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKey(downKey)) {
            if (xPos > leftWall) {
                xPos -= paddleSpeed;
            }
        }

        if (Input.GetKey(upKey)) {
            if (xPos < rightWall) {
                xPos += paddleSpeed;
            }
        }

        transform.localPosition = new Vector3(xPos,transform.position.y, 0);
    }
}

