using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SetScore(5, "Max Mustermann");
    }

    // Update is called once per frame
    void Update()
    {
        SetScore(78, "Wilfried Gruber");
    }

    public void SetScore(int score, string name)
    {
        int scoreValue = score;
        string nameValue = name;
        Debug.Log("score= " + scoreValue + " name= " + nameValue);
    }
}
