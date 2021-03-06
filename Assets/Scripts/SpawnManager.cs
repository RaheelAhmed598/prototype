using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 11;
    private float spawnRangeZ = 11;
    private float startDelay = 2.5f;
    private float spawnInterval = 2.0f;

    //private int score;
   // public TextMeshProUGUI scoreText;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
       //score = 0;
       //UpdateScore(0);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal() 
    {
        //Random generation of the animal index and spawn position
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnRangeZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        
        //UpdateScore(5);
    }

    //public void UpdateScore(int scoreToAdd)
    //{
    //    score += scoreToAdd;
    //    scoreText.text = "Score: " + score;
    //}
}
