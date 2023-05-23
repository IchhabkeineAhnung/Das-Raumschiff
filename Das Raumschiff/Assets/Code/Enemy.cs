using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float live = 2;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {

    }
    public float health = 100.0f;

    public void TakeDamage(float damage)
    {
        Debug.Log("2");
        // Reduce the enemy's health by the damage amount
        health -= damage;

        // Check if the enemy's health is zero or below
        if (health <= 0)
        {
            // Destroy the enemy object
            Destroy(gameObject);
        }
    }
}
