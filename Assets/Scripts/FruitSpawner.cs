using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawner : MonoBehaviour
{
    
    //public GameObject[] fruits;
    // Start is called before the first frame update
    void Start()
    {
        //location();
        addScore();
        InvokeRepeating("location", 1.0f, 5.0f);
        
      
    }

    // Update is called once per frame
    void Update()
    {
         
    }
    void Spawner ()
    {
        //Vector3 spawnFruit = new Vector3 (Random.Range (-9 , 9) , 0 , Random.Range (-9 , 9));
        //int temp = Random.Range  (0 , 3);
        
        //Instantiate(fruits[temp], spawnFruit, Quaternion.identity);
    }

    public virtual void location()
    {
        //Debug.Log("Parent Location");
    }
    public virtual void addScore()
    {
        //Debug.Log("Parent Addscore");
    }

    
}
