using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftController : MonoBehaviour
{
    private Rigidbody2D leftBumperRb;
    public float leftBumperForce;
    private GameManager GameManager;


    // Start is called before the first frame update
    void Start()
    {
        leftBumperRb = GetComponent<Rigidbody2D>();
        GameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J) && GameManager.isGameActive)
        {
            leftBumperRb.AddForce(Vector3.up * leftBumperForce, (ForceMode2D)ForceMode.Impulse);
        }
    }
}
