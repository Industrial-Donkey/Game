using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BillyPlayer : MonoBehaviour
{
    [SerializeField] public Transform groundCheckTransform = null;
    [SerializeField] private LayerMask playerMask;

    ///STarting speed = 5
    private float xSpeed = 5;

    private bool jumpKeyWasPressed = false;
    private bool isfloating = false;
    private bool isDead = false;
    private float horizontalInput;
    private Rigidbody rigidbodyComponent;
    ///public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        isDead = false;
        xSpeed = 5;
        InvokeRepeating("IncreaseSpeed", 5, 5);
        rigidbodyComponent = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Check if space key is pressed down
        if (isDead == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                jumpKeyWasPressed = true;
            }

            if (Input.GetKey(KeyCode.Space))
            {
                isfloating = true;
            }
            else
            {
                isfloating = false;
            }
        }
        //Gets horizontal input (left or right) and stores it as a float
        /// horizontalInput = Input.GetAxis("Horizontal");
    }

    // Update is called every physics second
    void FixedUpdate()
    {
        //Using horizontal input, player can control left and right. Not needed for this game, but
        //keeping it here anyway
        ///rigidbodyComponent.velocity = new Vector3(horizontalInput * 4, rigidbodyComponent.velocity.y, 0);

        if (isDead == false)
        {
            //checks and fixes speed if below 2
            if (xSpeed < 2)
            {
                xSpeed = 2;
            }
            //Sets Horizontal velocity to xSpeed, does not interrupt vertical velocity
            rigidbodyComponent.velocity = new Vector3(xSpeed, rigidbodyComponent.velocity.y, 0);
        }
        else
        {
            //Sets Horizontal velocity to 0, does not interrupt vertical velocity
            rigidbodyComponent.velocity = new Vector3(0, rigidbodyComponent.velocity.y, 0);
            transform.Rotate(2f, 0f, 0f, Space.Self);
        }

        if (isfloating)
        {
            rigidbodyComponent.AddForce(Vector3.up * 23, ForceMode.Acceleration);
        }

        if (Physics.OverlapSphere(groundCheckTransform.position, 0.1f, playerMask).Length == 0)
        {
            return;
        }

        //Makes the player jump
        if (jumpKeyWasPressed) //Checks if this bool is true
        {
            rigidbodyComponent.AddForce(Vector3.up * 8, ForceMode.VelocityChange);
            jumpKeyWasPressed = false;
        }

        GetComponent<Rigidbody>().AddForce(Physics.gravity * 15f, ForceMode.Acceleration);

    }

    //Function kills the player when colliding with different hazards
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "laser")
        {
            isDead = true;
            Invoke("sceneRestart", 2);
        }
        else if(other.gameObject.tag == "trash")
        {
            xSpeed -= 5;
        }
    }

    //Function reloads the game to the menu
    private void sceneRestart()
    {
        isDead = false;

        ///selects menu as next scene
        SceneManager.LoadScene(3);

        //This code reloads the CURRENT scene. aviods menu
        ///Scene scene = SceneManager.GetActiveScene();
        ///SceneManager.LoadScene(scene.name);
    }

    //Function increases the player's speed over time
    private void IncreaseSpeed()
    {
        xSpeed += 2;
    }
}
