using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public EnemySpawn Script;
    public GameObject Code;
    public float live;
    public float Dam;
    public void Start(){
        Code = GameObject.FindWithTag("Codespace");
        Script = Code.GetComponent<EnemySpawn>();
        float a = Mathf.Pow(1.1f,Script.number);
        live = 9 * a;
        Dam = 0.9f * a;
    }
    public void Update(){
        
    }
    public void takeDmg(float Dmg){
        live = live - Dmg;
        if(live <= 0){
            Script.restGegner--;
            Destroy(gameObject);
        }
    }
}
