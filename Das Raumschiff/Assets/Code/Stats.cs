using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    public GameObject RSchiff;
    public Movement Movement;
    public float live;
    public float livecount;
    public float speed;
    public float atkspeed;
    public float dmg;
    public float bulletspeed;
    public int bulletpen;
    public void Start(){
        RSchiff = GameObject.FindWithTag("Raumschiff");
        Movement = RSchiff.GetComponent<Movement>();
        bulletspeed = 0.05f;
        dmg = 5;
        bulletpen = 1;
        speed = 5;
        live = 5;
        livecount = 1;
        atkspeed = 10;
    }
    public void speedup(){
        speed = speed * 0.05f;
        Movement.up();
    }
    public void bspeedup(){
        bulletspeed = bulletspeed*0.25f;
    }
    public void dmgup(){
        dmg = dmg * 0.25f;
    }
    public void bpenup(){
        bulletpen++;
    }
    public void liveup(){
        live = 5 + livecount;
        livecount = livecount * 0.5f;
        Movement.up();
        Movement.lup();
    }
    public void atkup(){
        atkspeed = atkspeed * 0.9f;
        Movement.up();
    }
}
