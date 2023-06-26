using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameObject Stat;
    public Stats Code;
    public float bulletspeed;
    public int bulletpen;
    public float dmg;
    void Start(){
        Stat = GameObject.FindWithTag("Stats");
        Code = Stat.GetComponent<Stats>();
        dmg = Code.dmg;
        bulletpen = Code.bulletpen;
        bulletspeed = Code.bulletspeed;
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
