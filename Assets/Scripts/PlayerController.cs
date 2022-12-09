using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float minY = -4.48f;
    public float maxY = 0.9f;

    public GameObject groundChecker;
    public LayerMask whatIsGround;

    public float maxSpeed = 5.0f;
    public float jumpForce = 400.0f;

    Rigidbody2D playerObject;
    // Start is called before the first frame update
    void Start()
    {
        playerObject = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        //float movementValueX = 1.0f;
        float movementValueY = Input.GetAxis("Vertical");

        //playerObject.velocity = new Vector2(movementValueX * maxSpeed, movementValueY * maxSpeed);

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxY)
        {
            transform.Translate(Vector2.up);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minY)
        {
            transform.Translate(Vector2.down);
        }
    } 
	
}