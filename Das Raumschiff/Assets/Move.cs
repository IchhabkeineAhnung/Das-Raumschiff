using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Eingabe();
    }
    public void Eingabe(){
        if (Input.GetKey("up"))
        {
            Debug.Log("up");            
        }
    }
}
