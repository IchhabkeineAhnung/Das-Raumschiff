using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCon : MonoBehaviour
{
    public GameObject Buttondmg;
    public GameObject Buttonatk;
    public GameObject Buttonspeed;
    public GameObject Buttonbspeed;
    public GameObject Buttonlive;
    public GameObject Buttonpen;
    public void Start(){
        Buttondmg = GameObject.FindWithTag("dmg");
        Buttonatk = GameObject.FindWithTag("atk");
        Buttonspeed = GameObject.FindWithTag("speed");
        Buttonlive = GameObject.FindWithTag("live");
        Buttonpen = GameObject.FindWithTag("pen");
        Buttonbspeed = GameObject.FindWithTag("bspeed");
    }
    public void dmgver(){
        Buttondmg.transform.position.Set(0,1000,0);
    }
    public void atkver(){
        Buttonatk.transform.position.Set(0,1000,0);
    }
    public void speedver(){
        Buttonspeed.transform.position.Set(0,1000,0);
    }
    public void bspeedver(){
        Buttonbspeed.transform.position.Set(0,1000,0);
    }
    public void livever(){
        Buttonlive.transform.position.Set(0,1000,0);
    }
    public void penver(){
        Buttonpen.transform.position.Set(0,1000,0);
    }
    public void Schieber(){
        int a = rnd();
        int b = rnd();
        int c = rnd();
        while(a == b || a == c || b == c){
            a = rnd();
            b = rnd();
            c = rnd();
        }
        
    }
    public GameObject Switschi(int a){
        switch (a)
        {
            case 1:
            return Buttonatk;
            case 2:
            return Buttonbspeed;
            case 3:
            return Buttondmg;
            case 4:
            return Buttonlive;
            case 5:
            return Buttonpen;
            case 6:
            return Buttonspeed;
            default:
            return null;
        }
    }
    public int rnd(){
        int a;
        a = Random.Range(1 , 7);
        return a;
    }
}
