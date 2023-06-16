using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float bulletspeed = 0.02f;
    public int bulletpen = 2;
    public float dmg = 1;
    void Start(){
        bulletpen = 1;
        bulletspeed = 0.1f;
        dmg = 5;
    }
    // Update is called once per frame
    void Update()
    {
        movement();
        Des();
    }
    public void movement(){
        transform.Translate(Vector3.right*bulletspeed);
    }
    public void Des(){
        if(transform.position.x > 10){
            Object.Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D col){
        if(col.CompareTag("Enemy")){
            Enemy enemy = col.GetComponent<Enemy>();
            enemy.takeDmg(dmg);
            bulletpen--;
            if(bulletpen < 0){
                Destroy(gameObject);
            }
        }
    }
}
