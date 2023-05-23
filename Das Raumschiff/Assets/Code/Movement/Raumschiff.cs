using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raumschiff : MonoBehaviour
{
    public GameObject Bullet;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        shoot();
    }

    public void shoot(){
        if(Input.GetKeyUp(KeyCode.Space)){
            Instantiate(Bullet,transform.position);
        }
    }

    private void Instantiate(GameObject bullet, Vector3 position)
    {
        throw new NotImplementedException();
    }
}
