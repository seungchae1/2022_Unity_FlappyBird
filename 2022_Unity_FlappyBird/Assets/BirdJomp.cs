﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdJomp : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpPower;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * jumpPower; //Vector2는 (x,y)로 나타내는 2차원 좌표 //Vector.up은 (0,1)
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        SceneManager.LoadScene("GameOverScene");
    }
}
