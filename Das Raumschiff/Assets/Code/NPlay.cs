using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NPlay : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Starten(){
        SceneManager.LoadScene("Game");
    }
}
