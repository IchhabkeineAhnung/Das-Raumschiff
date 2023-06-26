using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Bullet : MonoBehaviour
{
    public float bulletspeed = 0.02f;
    public float dmg;
    void Start(){
        bulletspeed = 0.05f;
        dmg = 1;
    }
    // Update is called once per frame
    void Update()
    {
        movement();
        Des();
    }
    public void movement(){
        transform.Translate(Vector3.left*bulletspeed);
    }
    public void Des(){
        if(transform.position.x < -10){
            Object.Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D col){
        if(col.CompareTag("Raumschiff")){
            Movement raumschiff = col.GetComponent<Movement>();
            raumschiff.takeDmg(dmg);
            Destroy(gameObject);
        }
    }
}
