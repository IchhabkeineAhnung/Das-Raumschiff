using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public bool a;
    public GameObject enemy;
    public int restGegner;
    public int number;
    public Vector2 vec = Vector2.right*2;
    // Start is called before the first frame update
    void Start()
    {
        a = true;
        number = 1;
        nextEnemy();
    }

    // Update is called once per frame
    void Update()
    {
        if(restGegner <= 0 && a){
        a = false;
        Invoke("nextWave",1.5f);
        }
        if(Input.GetKeyDown(KeyCode.Q)){
            Erstellen(transform.position);
        }
    }
    public void Erstellen(Vector3 pos){
        Instantiate(enemy,pos,transform.rotation);
    }
    public void nextWave(){
        restGegner = 0;
        nextEnemy();
        int b = 0 + number;
        int c = 2 + number;
        float d = Mathf.Round(Random.Range(b,c));
        while(d>0){
            nextEnemy();
            d--;
        }
        number++;
        a = true;
    }
    public void enemydead(){
        restGegner--;
    }
    public float Getnumber(){
        return number;
    }
    public void nextEnemy(){
        float x = Random.Range(0.5f,5);
        float y = Random.Range(-3,3);
        Vector3 b = new Vector3(x,y,150);
        Erstellen(b);
        restGegner++;
    }
}
