using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class BumperPoints : MonoBehaviour
{
   
    private GameManager GameManager;
    public int pointValue;

    

    // Update is called once per frame
    void Start()
    {
        GameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        //Trying to get score to be added on collision and Idk why this won't work. Once it works, duplicate script for 50 and 100 bumpers.
        if (GameManager.isGameActive == true)
        {
            GameManager.UpdateScore(pointValue);
        }
           
    }
}