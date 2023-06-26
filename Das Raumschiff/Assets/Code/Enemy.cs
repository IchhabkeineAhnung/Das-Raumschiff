using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public EnemySpawn Script;
    public GameObject Code;
    public GameObject BulletE;
    public bool f;
    public float live;
    public float Dam;
    public void Start(){
        Code = GameObject.FindWithTag("Codespace");
        Script = Code.GetComponent<EnemySpawn>();
        float a = Mathf.Pow(1.1f,Script.number);
        live = 9 * a;
        Dam = 0.9f * a;
        f = true;
    }
    public void Update(){
        shoot();
    }
    public void shoot(){
        if(f == true){
            Invoke("shootbullet",timestop());
            f = false;
        }
    }
    public void shootbullet(){
        Instantiate(BulletE,transform.position,transform.rotation);
        f = true;
    }
    public float timestop(){
        float a = Mathf.Pow(1.1f,Script.number);
        float b = 1 + 0.1f*a;
        float c = 1.5f + 0.2f*a;
        float d = UnityEngine.Random.Range(b,c);
        return d;
    }
    public void takeDmg(float Dmg){
        live = live - Dmg;
        if(live <= 0){
            Script.restGegner--;
            Destroy(gameObject);
        }
    }
}
