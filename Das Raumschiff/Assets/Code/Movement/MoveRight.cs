using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : MonoBehaviour
{
    public float bulletspeed = 0.02f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        movement();
        Des();
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
