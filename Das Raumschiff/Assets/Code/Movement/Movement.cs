using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed; // The speed of the movement
    private float verticalInput; // Input for vertical movemen
    public Stats stats;

    // Start is called before the first frame update
    void Start()
    {
        stats = GetComponent<Stats>();
        speed = stats.speed;
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
        transform.Translate(Vector3.right* speed * Time.deltaTime * verticalInput);
    }
}
