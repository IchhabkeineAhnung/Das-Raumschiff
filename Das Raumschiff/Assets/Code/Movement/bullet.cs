using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float bulletspeed = 0.02f;
    public int bulletpen = 1;
    public float dmg = 1;

    // Update is called once per frame
    void Update()
    {
        movement();
        Des();
    }
     public float damage = 10.0f;

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("1");
        // Check if the bullet collides with an enemy
        if (other.gameObject.CompareTag("Enemy"))
        {
            // Get the Enemy script from the collided object
            Enemy enemy = other.gameObject.GetComponent<Enemy>();

            // Check if the enemy script was found
            if (enemy != null)
            {
                // Apply damage to the enemy
                enemy.TakeDamage(damage);

                // Destroy the bullet
                Destroy(gameObject);
            }
        }
    }
    public void movement(){
        if(transform.position.z==5){
            bulletspeed=0;
        }
        else{    
            transform.Translate(Vector3.right*bulletspeed);
        }
    }
    public void Des(){
        if(transform.position.x>10){
            Object.Destroy(gameObject);
        }
    }
}
