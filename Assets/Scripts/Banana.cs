using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : FruitSpawner
{
    public GameObject bananaObject;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("location", 4.0f, 5.0f);
        //location();
        addScore();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public override void location()
    {
        Debug.Log("Apple Location");
        Vector3 spawnBanana = new Vector3 (Random.Range (-9 , 9) , 0 , Random.Range (-9 , 9));
        //int temp = Random.Range  (0 , 3);
        Instantiate(bananaObject, spawnBanana, Quaternion.identity);
    }
    public override void addScore()
    {
        Debug.Log("Banana");
    }
    void OnTriggerEnter(Collider other)
   {
       if(other.gameObject.tag == "Player")
       {
           Destroy(gameObject);
           
       }
   }
}
