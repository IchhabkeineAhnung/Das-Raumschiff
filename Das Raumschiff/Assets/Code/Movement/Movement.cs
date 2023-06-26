using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    public GameObject Stat;
    public Stats Code;
    public GameObject Bullet;
    public float speed;
    private float verticalInput;
    public float ti;
    public float atkcooldown;
    public float live;

    // Start is called before the first frame update
    void Start()
    {
        Stat = GameObject.FindWithTag("Stats");
        Code = Stat.GetComponent<Stats>();
        up();
        lup();
    }

    // Update is called once per frame
void Update()
    {
        movement();
        shoot();
    }
    public void up(){
        speed = Code.speed;
        atkcooldown = Code.atkspeed;
    }
    public void lup(){
        live = Code.live;
    }
    public void movement(){
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * speed * Time.deltaTime * verticalInput);
        if(transform.position.y >= 5 || transform.position.y <= -5){
            SceneManager.LoadScene("Game_Over");
        }
    }
    public void shoot(){
        if(Input.GetKey(KeyCode.Space)){
            if(ti > atkcooldown){
                Instantiate(Bullet,transform.position,Quaternion.identity);
                ti = 0;
            }
        }
        ti = ti + 10 * Time.deltaTime;
    }
    public void takeDmg(float Dmg){
        live = live - Dmg;
        if(live <= 0){
            SceneManager.LoadScene("Game_Over");
        }
    }
}
