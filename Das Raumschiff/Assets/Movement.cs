using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float a=1000;
    public Rigidbody2D b;
    public Vector2 c;

    void Awake(){
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Eingabe(){
        if (Input.GetKey("up"))
        {
            c=(0,a);
            b.velocity=)c;
            Debug.Log("up");            
        }
    }
}
