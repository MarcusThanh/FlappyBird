using System;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SocialPlatforms.Impl;
public class Player : MonoBehaviour
{


    [SerializeField] private float _flyPower = 1.0f;
    Rigidbody2D rb;
    BoxCollider2D bc;
    [SerializeField] private int _score = 0;
    private bool _isDead;

    private HashSet<string> _setCollide;
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _isDead = false;
        Debug.Log("Hello World");
    }

    // Update is called once per frame
    void Update()
    {
        if(_isDead)
        {
            return;
        }

        if(Keyboard.current.spaceKey.wasPressedThisFrame)
        {

            rb.linearVelocityY = 0;
            rb.AddForce(new UnityEngine.Vector2(0f, _flyPower),ForceMode2D.Impulse);
            Debug.Log("Bird Fly");

        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {



        Debug.Log("Collide " + collision.gameObject.name);

        if(collision.gameObject.CompareTag("Coin"))
        {
            Debug.Log("Score increased");
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collide " + collision.gameObject.name);

    }
}
