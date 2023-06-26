using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    public GameObject Bullet;
    public float speed;
    private float verticalInput;
    public float ti;
    public float atkcooldwn = 10;
    public float live;

    // Start is called before the first frame update
    void Start()
    {
        live = 5;
    }

    // Update is called once per frame
void Update()
    {
        movement();
        shoot();
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
            if(ti > atkcooldwn){
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
