using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    private Text text;
    public GameObject theScore;
    static int score;

    // Start is called before the first frame update
    void Start()
    {
        text = GameObject.Find("Score").GetComponent<Text>();
        //theScore.GetComponent<Text>().text = "Score: " + score;
    }

// Update is called once per frame
void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        score += 5;
        //theScore.GetComponent<Text>().text = "Score: " + score;
        text.text = score.ToString();
        Debug.Log("Scoring system");
        Destroy(gameObject);
    }
}
