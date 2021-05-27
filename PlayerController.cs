using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;
    public float jumpForce;

    private Rigidbody2D playerRigidBody2D;
    public LayerMask isGround;
    public bool ground;
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;
    
    private CircleCollider2D playerCollider2D;
    private Animator playerAnimatorController;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidBody2D = GetComponent<Rigidbody2D>();
        playerCollider2D = GetComponent<CircleCollider2D>();
        playerAnimatorController = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(TutorialManager.tutorialPassed){
        if(ObstacleController.isHit){
            playerAnimatorController.SetBool("Death", true);
            if(speed > 0){
                speed -= 0.1f;
            } else {
                FindObjectOfType<GameManager>().EndGame();
            }
            playerRigidBody2D.velocity = new Vector2(speed, playerRigidBody2D.velocity.y);


        } else {
            playerAnimatorController.SetFloat("Speed", speed);
            playerRigidBody2D.velocity = new Vector2(speed, playerRigidBody2D.velocity.y);
        }

        if(Input.GetKeyDown(KeyCode.Z)){
            Attack();
        }

        ground = Physics2D.IsTouchingLayers(playerCollider2D, isGround);
        if(Input.GetButtonDown("Jump") && ground){
            playerRigidBody2D.velocity = new Vector2(playerRigidBody2D.velocity.x, jumpForce);
        }

        }
    }

    void Attack(){
        playerAnimatorController.SetTrigger("Attack");
    }
}
