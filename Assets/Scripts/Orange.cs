using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orange : FruitSpawner
{
    public GameObject orangeObject;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("location", 3.0f, 10.0f);
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
        Vector3 spawnOrange = new Vector3 (Random.Range (-9 , 9) , 0 , Random.Range (-9 , 9));
        //int temp = Random.Range  (0, 2);
        Instantiate(orangeObject, spawnOrange, Quaternion.identity);
    }
    public override void addScore()
    {
        Debug.Log("Orange");
    }
    void OnTriggerEnter(Collider other)
   {
       if(other.gameObject.tag == "Player")
       {
           Destroy(gameObject);
       }
   }
}
