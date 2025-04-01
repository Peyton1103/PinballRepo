using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightController : MonoBehaviour
{
    private Rigidbody2D rightBumperRb;
    public float rightBumperForce;
    private GameManager GameManager;


    // Start is called before the first frame update
    void Start()
    {
        rightBumperRb = GetComponent<Rigidbody2D>();
        GameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha7) && GameManager.isGameActive == true)
        {
            rightBumperRb.AddForce(Vector3.up * rightBumperForce, (ForceMode2D)ForceMode.Impulse);
        }
    }
}
