using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour
{
    void Update()
    {
        if(Input.GetMouseButtonUp(0)){
            SceneManager.LoadScene("Start");
        }
    }
}
