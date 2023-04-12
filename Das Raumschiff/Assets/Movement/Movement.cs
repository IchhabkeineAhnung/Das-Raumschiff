using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5.0f; // The speed of the movement
    private float verticalInput; // Input for vertical movemen

    void Awake(){
        
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
void Update()
    {
        movement();
    }
    
    public void movement(){
         // Get input for vertical movement
        verticalInput = Input.GetAxis("Vertical");

        // Move the GameObject up or down based on the input
        transform.Translate(Vector3.up * speed * Time.deltaTime * verticalInput);
    }

}
