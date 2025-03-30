using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTilt : MonoBehaviour
{

    private GameManager GameManager;
    private Rigidbody2D ballRb;
    public float ballForce;

    // Start is called before the first frame update
    void Start()
    {
        GameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        ballRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && Input.GetKeyDown(KeyCode.LeftArrow) && (GameManager.isGameActive == true))
        {
            ballRb.AddForce(Vector3.left * ballForce, (ForceMode2D)ForceMode.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.D) && Input.GetKeyDown(KeyCode.RightArrow) && (GameManager.isGameActive == true))
        {
            ballRb.AddForce(Vector3.right * ballForce, (ForceMode2D)ForceMode.Impulse);
        }


    }
}
