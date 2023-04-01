using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public int a=100;
    public Rigidbody2D b;
    public UnityEngine.Vector2 c;

    void Awake(){
        
    }
    // Start is called before the first frame update
    void Start()
    {
        c = new UnityEngine.Vector2(0,a);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Eingabe(){
        if (Input.GetKey("up"))
        {
            b.AddForce(c);
            Debug.Log("up");            
        }
    }
}
