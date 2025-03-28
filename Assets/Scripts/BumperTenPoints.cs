using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class BumperPoints : MonoBehaviour
{
    public GameObject bumper10;
    public GameObject ball;

    GameManager gM;

    // Update is called once per frame
    void Start()
    {
        gM = FindObjectOfType<GameManager>();
    }

    void OnTriggerEnter(Collider ball)
    {
        //Trying to get score to be added on collision and Idk why this won't work. Once it works, duplicate script for 50 and 100 bumpers.
        gM.score += 10;
    }
}