using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Transform playerPosition;
    Rigidbody rb;
    float jumpTimer;
    [SerializeField] int playerLvl;
    [SerializeField] float movementSpeed = 7f;
    [SerializeField] float jumpForce = 5f;
    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask ground;

    [SerializeField] Transform levelCheck;
    [SerializeField] LayerMask level;
    // Vector3 spawnLocationOne = new Vector3(-100, -4, -3);
    // Vector3 spawnLocationTwo = new Vector3(-75, -4, -3);
    // Vector3 spawnLocationThree = new Vector3(-100, -4, -3);
    // Vector3 spawnLocationFour = new Vector3(-100, -4, -3);
    // Vector3 spawnLocationFive = new Vector3(-100, -4, -3);
    // Vector3 spawnLocationSix = new Vector3(-100, -4, -3);
    // Vector3 spawnLocationSeven = new Vector3(-100, -4, -3);
    // Vector3 spawnLocationEight = new Vector3(-100, -4, -3);

    PushableStonesScript pushableStonesScript;
    [SerializeField] GameObject stones;
    

    // Start is called before the first frame update
    void Start()
    {
        // rb = GetComponent<Rigidbody>;
        rb = GetComponent<Rigidbody>();
        playerPosition = GetComponent<Transform>();
        // ResetPlayerPosition();
        BoxCollider lvl2 = GetComponent<BoxCollider>();
        pushableStonesScript = stones.GetComponent<PushableStonesScript>();
        
        playerLvl = -1;

    }


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("r"))
        {
            // playerPosition.transform.position = levelOne;
            ResetPlayerPosition();

            pushableStonesScript.ResetStones();
        }

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
            jumpTimer = 300;
        }

        if (jumpTimer != 0)
        {
            jumpTimer--;
        }

        rb.velocity = new Vector3(verticalInput * movementSpeed, rb.velocity.y, horizontalInput * -movementSpeed);



    }

    bool IsGrounded()
    {
        return Physics.CheckSphere(groundCheck.position, .1f, ground);
    }
    
    private void OnTriggerEnter(Collider other)
    {

        print(other.gameObject.tag);
        
        if (other.gameObject.tag == "Level1")
        {
            playerLvl = 1;
            
        }
// asd
        else if (other.gameObject.tag == "Level2")
        {
            playerLvl = 2;
        }

        else if (other.gameObject.tag == "Level3")
        {
            playerLvl = 3;
        }

        else if (other.gameObject.tag == "Level4")
        {
            playerLvl = 4;
        }

        else if (other.gameObject.tag == "Level5")
        {
            playerLvl = 5;
        }

        else if (other.gameObject.tag == "Level6")
        {
            playerLvl = 6;
        }

        else if (other.gameObject.tag == "Level7")
        {
            playerLvl = 7;
        }

        else if (other.gameObject.tag == "Level8")
        {
            playerLvl = 8;
        }

    }

    void ResetPlayerPosition()
    
    {
                        if (playerLvl < 1 || playerLvl > 8)
                        {
                            playerLvl = 1;
                        }
                        else
                        {
                            switch (playerLvl)
                            {
                                case 1:
                                    playerPosition.transform.position = new Vector3(-45, -4.4f, -3);
                                    break;
                                case 2:
                                playerPosition.transform.position = new Vector3(-28.7f, -4.4f, -3);
                                break;
                                case 3:
                                    playerPosition.transform.position = new Vector3(-8.4f, -4.4f, -3);
                                break;
                                case 4:
                                playerPosition.transform.position = new Vector3(15.64f, -4.4f, -3);
                                break;
                                // case 5:
                                //     playerPosition.transform.position = spawnLocationFive;
                                //     break;
                                // case 6:
                                //     playerPosition.transform.position = spawnLocationFive;
                                //     break;
                                // case 7:
                                //     playerPosition.transform.position = spawnLocationFive;
                                //     break;
                                // case 8:
                                //     playerPosition.transform.position = spawnLocationFive;
                                //     break;
                            }
                        }
                    }
    
                }

