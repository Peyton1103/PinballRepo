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
        Destroy(ball);
        gM.score += 10;
    }
}