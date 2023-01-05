using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    Transform playerPosition;
    Rigidbody rb;
    float jumpTimer;
    [SerializeField] int playerLevel;
    [SerializeField] float movementSpeed = 7f;
    [SerializeField] float jumpForce = 5f;
    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask ground;

    [SerializeField] Transform levelCheck;
    [SerializeField] LayerMask level;
    Vector3 spawnLocationOne = new Vector3(-100,-4,-3);
    Vector3 spawnLocationTwo = new Vector3(-75,-4,-3);
    Vector3 spawnLocationThree = new Vector3(-100,-4,-3);
    Vector3 spawnLocationFour = new Vector3(-100,-4,-3);
    Vector3 spawnLocationFive = new Vector3(-100,-4,-3);

    PushableStonesScript pushableStonesScript;
    [SerializeField] GameObject stones;


    // Start is called before the first frame update
    void Start()
    {
        // rb = GetComponent<Rigidbody>;
        rb = GetComponent<Rigidbody>();
        playerPosition = GetComponent<Transform>();
        ResetPlayerPosition();
        BoxCollider lvl2 = GetComponent<BoxCollider>();
        pushableStonesScript = stones.GetComponent<PushableStonesScript>();
        
    }


    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown("r")){
            // playerPosition.transform.position = levelOne;
    
            pushableStonesScript.ResetStones();
            ResetPlayerPosition();
        }

        playerLevel = IsNextLevel();

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        if(Input.GetButtonDown("Jump") && IsGrounded()){
        rb.velocity = new Vector3(rb.velocity.x,jumpForce,rb.velocity.z);
        jumpTimer = 300;
        }

        if (jumpTimer != 0){
            jumpTimer--;
        }
        
        rb.velocity = new Vector3(verticalInput*movementSpeed,rb.velocity.y,horizontalInput*-movementSpeed);
    
    }
    bool IsGrounded()
    {
       return Physics.CheckSphere(groundCheck.position, .1f, ground);
    }
    int IsNextLevel(){
    if (Physics.CheckSphere(levelCheck.position, .1f, level)){
        return 2;
    } else return playerLevel;
    }

    void ResetPlayerPosition(){
    if (playerLevel < 1 || playerLevel >5 )
    {
    playerLevel = 1;
    playerPosition.transform.position = spawnLocationOne;
}else
    {
        switch (playerLevel) 
{
  case 1:
    playerPosition.transform.position = spawnLocationOne;
    break;
  case 2:
    playerPosition.transform.position = spawnLocationTwo;
    break;
  case 3:
    playerPosition.transform.position = spawnLocationThree;
    break;
  case 4:
    playerPosition.transform.position = spawnLocationFour;
    break;
  case 5:
    playerPosition.transform.position = spawnLocationFive;
    break;
}
}






}
}