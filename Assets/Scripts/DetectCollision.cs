using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DetectCollision : MonoBehaviour
{
    private Text text;
    private GameObject theScore;
    static int score;
    
    //private SpawnManager spawnManager;
    

    // Start is called before the first frame update
    void Start()
    {
       text = GameObject.Find("Score").GetComponent<Text>();
        //spawnManager = GameObject.Find("Spawn Manager").GetComponent<SpawnManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        //score += 5;
        if (this.name == "Food_Organic_Pear_02(Clone)")
        {
            if (score==0) 
            {
              
               score += 3;
            }

            //extra point for high score
            else if (this.name == "Animal_Chicken_Brown(Clone)")
            {
                
                score += 10;
            }
            else 
            {
                
                score += 5;
            }
        }
        text.text = score.ToString();
        Destroy(gameObject);
        Destroy(other.gameObject);
        //theScore.GetComponent<Text>().text = "Score: " + score;
        //Debug.Log("Scoring system");
        //spawnManager.UpdateScore(5);
    }
}
