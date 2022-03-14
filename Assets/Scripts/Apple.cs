using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Apple : FruitSpawner
{
    public GameObject appleObject;
    [SerializeField] Text scoreDisplay;
    int score=0;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("location", 2.0f, 15.0f);
        //location();
        addScore();
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }
    //  private void OnEnable()
    // {
    //     if (instance == null)
    //     instance = this;
    // }
    public void UpdateScore(int score)
    {
        score += 10;
        scoreDisplay.text = score.ToString();


    }
     public override void location()
    {
        Debug.Log("Apple Location");
        Vector3 spawnApple = new Vector3 (Random.Range (-9 , 9) , 0 , Random.Range (-9 , 9));
        //int temp = Random.Range  (0 , 1);
        Instantiate(appleObject, spawnApple, Quaternion.identity);
    }
    public override void addScore()
    {
        Debug.Log("Apple");
    }
    void OnTriggerEnter(Collider other)
   {
       if(other.gameObject.tag == "Player")
       {
           Destroy(gameObject);
           UpdateScore(score);
       }
   }
}
